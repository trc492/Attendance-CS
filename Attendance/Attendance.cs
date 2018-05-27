using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace Attendance
{
    public partial class Attendance : Form
    {
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, Int32 nCmdShow);

        private const int SW_SHOWNORMAL = 1;

        const string m_appName = "Attendance Recorder";
        const int m_numMeetingInfoFields = 5;

        OpenFileDialog m_openFileDialog = new OpenFileDialog();
        List<Student> m_students = new List<Student>();
        bool m_meetingCreated = false;

        private bool EnsureSingleInstance(string instName)
        {
            bool bSingleInstance = true;
            Process currentProcess = Process.GetCurrentProcess();

            var runningProcess = (from process in Process.GetProcesses()
                                  where
                                    process.Id != currentProcess.Id &&
                                    process.ProcessName.Equals(
                                      currentProcess.ProcessName,
                                      StringComparison.Ordinal) &&
                                    process.MainWindowTitle.Contains(instName)
                                  select process).FirstOrDefault();

            if (runningProcess != null)
            {
                bSingleInstance = false;
                MessageBox.Show(this,
                                "Another instance of the program already opened " +
                                instName +
                                ".\nClick OK to close this instance and bring the other instance to the foreground.",
                                m_appName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                ShowWindow(runningProcess.MainWindowHandle, SW_SHOWNORMAL);
                SetForegroundWindow(runningProcess.MainWindowHandle);
                Application.Exit();
            }

            return bSingleInstance;
        }   //EnsureSingleInstance

        private void EnableMeetingInfo(bool enabled)
        {
            meetingInfo.Enabled = enabled;
            dateLabel.Enabled = enabled;
            startTimeLabel.Enabled = enabled;
            endTimeLabel.Enabled = enabled;
            meetingLabel.Enabled = enabled;
            placeLabel.Enabled = enabled;
            dateTimePicker.Enabled = enabled;
            startTime.Enabled = enabled;
            endTime.Enabled = enabled;
            meetingName.Enabled = enabled;
            meetingPlace.Enabled = enabled;
            createButton.Enabled = enabled;
        }   //EnableMeetingInfo

        private void EnableInStudentList(bool enabled)
        {
            checkInGroup.Enabled = enabled;
            inStudentsLabel.Enabled = enabled;
            inStudentList.Enabled = enabled;
        }   //EnableInStudentList

        private void EnableOutStudentList(bool enabled)
        {
            checkOutGroup.Enabled = enabled;
            outStudentsLabel.Enabled = enabled;
            outStudentList.Enabled = enabled;
        }   //EnableOutStudentList

        private int FindStudent(String name)
        {
            int index = -1;

            foreach (Student s in m_students)
            {
                if (String.Compare(s.name, name) == 0)
                {
                    index = m_students.IndexOf(s);
                    break;
                }
            }

            return index;
        }   //FindStudent

        private String ParseNextToken(String[] tokens, ref int idx)
        {
            String tok = null;

            if (idx < tokens.Length)
            {
                if (tokens[idx].StartsWith("\""))
                {
                    tok = tokens[idx].Substring(1);
                    idx++;
                    while (idx < tokens.Length)
                    {
                        tok += ",";
                        if (tokens[idx].EndsWith("\""))
                        {
                            tok += tokens[idx].Substring(0, tokens[idx].Length - 1);
                            idx++;
                            break;
                        }
                        else
                        {
                            tok += tokens[idx];
                            idx++;
                        }
                    }
                }
                else
                {
                    tok = tokens[idx];
                    idx++;
                }
            }

            return tok;
        }   //ParseNextToken

        private int ParseStudents(String line)
        {
            int numStudents = 0;
            int cInfoFields = 0;
            String[] tokens = line.Split(new char[] { ',' });
            int idx = 0;
            String tok;

            while (idx < tokens.Length)
            {
                try
                {
                    tok = ParseNextToken(tokens, ref idx);
                    if (cInfoFields < m_numMeetingInfoFields)
                    {
                        cInfoFields++;
                    }
                    else
                    {
                        m_students.Add(new Student(tok, Student.StudentState.none));
                        inStudentList.Items.Add(tok);
                        numStudents++;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(this,
                                    "Failed to parse student names.\n" + err.Message,
                                    m_appName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            return numStudents;
        }   //ParseStudents

        private String GetAppBuildTime()
        {
            String appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            DateTime fileTime = File.GetLastWriteTime(appPath);
            return fileTime.ToString();
        }   //GetAppBuildTime

        public Attendance()
        {
            InitializeComponent();

            dateTimePicker.Value = DateTime.Now;

            EnableMeetingInfo(false);
            EnableInStudentList(false);
            EnableOutStudentList(false);
            checkInButton.Enabled = false;
            checkOutButton.Enabled = false;

            m_openFileDialog.InitialDirectory = ".";
            m_openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            m_openFileDialog.FilterIndex = 1;
            m_openFileDialog.RestoreDirectory = true;
        }   //Attendance

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                            m_appName +
                            "\nVersion 1.07\n\n" +
                            "Copyright (c) Titan Robotics Club. All rights reserved.\n" +
                            "Build: " + GetAppBuildTime() + "\n" +
                            "Author: Michael Tsang",
                            m_appName,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }   //aboutToolStripMenuItem_Click

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (EnsureSingleInstance(m_openFileDialog.FileName))
                {
                    StreamReader sr = null;
                    String line = null;

                    try
                    {
                        sr = new StreamReader(m_openFileDialog.FileName);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(this,
                                        "Failed to open file " + m_openFileDialog.FileName + "\n" + err.Message,
                                        m_appName,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    if (sr != null)
                    {
                        try
                        {
                            line = sr.ReadLine();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(this,
                                            "Failed to read file " + m_openFileDialog.FileName + "\n" + err.Message,
                                            m_appName,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            Application.Exit();
                        }

                        if ((line != null) && (ParseStudents(line) > 0))
                        {
                            EnableMeetingInfo(true);
                            openToolStripMenuItem.Enabled = false;
                            this.Text = m_openFileDialog.FileName + " - " + m_appName;
                        }

                        sr.Close();
                    }
                }
            }
        }   //openToolStripMenuItem_Click

        private void inStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inStudentList.SelectedIndex != -1)
            {
                int index = FindStudent(inStudentList.SelectedItem.ToString());

                if (index != -1)
                {
                    checkInButton.Enabled = (m_students.ElementAt(index).state ==
                                             Student.StudentState.none);
                }
            }
        }   //inStudentList_SelectedIndexChanged

        private void outStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (outStudentList.SelectedIndex != -1)
            {
                int index = FindStudent(outStudentList.SelectedItem.ToString());

                if (index != -1)
                {
                    checkOutButton.Enabled = (m_students.ElementAt(index).state ==
                                              Student.StudentState.checkedIn);
                }
            }
        }   //outStudentList_SelectedIndexChanged

        private void checkInButton_Click(object sender, EventArgs e)
        {
            if (inStudentList.SelectedIndex != -1)
            {
                int index = FindStudent(inStudentList.SelectedItem.ToString());

                if (index != -1)
                {
                    m_students.ElementAt(index).CheckIn();
                    outStudentList.Items.Add(inStudentList.SelectedItem.ToString());
                    inStudentList.Items.Remove(inStudentList.SelectedItem);
                    inStudentList.SelectedIndex = -1;
                    inStudentList.Text = "";
                    checkInButton.Enabled = false;
                }
            }
        }   //checkInButton_Click

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (outStudentList.SelectedIndex != -1)
            {
                int index = FindStudent(outStudentList.SelectedItem.ToString());

                if (index != -1)
                {
                    m_students.ElementAt(index).CheckOut();
                    outStudentList.Items.Remove(outStudentList.SelectedItem);
                    outStudentList.SelectedIndex = -1;
                    outStudentList.Text = "";
                    checkOutButton.Enabled = false;
                }
            }
        }   //checkOutButton_Click

        private void createButton_Click(object sender, EventArgs e)
        {
            if (meetingName.Text != String.Empty &&
                meetingPlace.Text != String.Empty)
            {
                EnableMeetingInfo(false);
                EnableInStudentList(true);
                EnableOutStudentList(true);
                m_meetingCreated = true;
            }
        }   //createButton_Click

        private bool ConfirmClose()
        {
            bool bClose = true;

            if (m_meetingCreated)
            {
                string msg = "Closing this application will conclude this meeting and check everybody out. Are you sure? Select \"Yes\" to continue and \"No\" to cancel.";
                DialogResult result = MessageBox.Show(this,
                                                      msg, 
                                                      m_appName,
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    // If user doesn't want to close, cancel closure
                    bClose = false;
                }
            }

            return bClose;
        }   //ConfirmClose

        private void Attendance_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = !ConfirmClose();
        }   //Attendance_Closing

        private void Attendance_Closed(object sender, EventArgs e)
        {
            if (m_meetingCreated)
            {
                while (outStudentList.Items.Count > 0)
                {
                    outStudentList.SelectedIndex = 0;
                    int index = FindStudent(outStudentList.SelectedItem.ToString());
                    if (index != -1)
                    {
                        m_students.ElementAt(index).CheckOut();
                    }
                    outStudentList.Items.Remove(outStudentList.SelectedItem);
                }

                StreamWriter sw = null;

                try
                {
                    sw = new StreamWriter(m_openFileDialog.FileName, true);
                }
                catch (Exception err)
                {
                    MessageBox.Show(this,
                                    "Failed to open file " + m_openFileDialog.FileName + "\n" + err.Message,
                                    m_appName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    Application.Exit();
                }

                if (sw != null)
                {
                    try
                    {
                        sw.Write(dateTimePicker.Value.ToString("d"));
                        sw.Write("," + startTime.SelectedItem.ToString());
                        sw.Write("," + endTime.SelectedItem.ToString());
                        sw.Write(",\"" + meetingPlace.Text.Replace("\"", "") + "\"");
                        sw.Write(",\"" + meetingName.Text.Replace("\"", "") + "\"");
                        foreach (Student s in m_students)
                        {
                            sw.Write("," + s.TimeParticipated());
                        }
                        sw.WriteLine();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(this,
                                        "Failed to write file " + m_openFileDialog.FileName + "\n" + err.Message,
                                        m_appName,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    sw.Close();
                }
            }
        }   //Attendance_Closed

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmClose())
            {
                Attendance_Closed(sender, e);
                Application.Exit();
            }
        }   //closeToolStripMenuItem_Click
    }   //class Attendance

    public class Student
    {
        public enum StudentState {none = 0, checkedIn, checkedOut};
        public String name;
        public StudentState state;
        DateTime checkInTime;
        DateTime checkOutTime;

        public Student(String n, StudentState s)
        {
            name = n;
            state = s;
        }   //Student

        public void CheckIn()
        {
            checkInTime = DateTime.Now;
            state = StudentState.checkedIn;
        }   //CheckIn

        public void CheckOut()
        {
            checkOutTime = DateTime.Now;
            state = StudentState.checkedOut;
        }   //CheckOut

        public int TimeParticipated()
        {
            TimeSpan timeSpent = checkOutTime.Subtract(checkInTime);
            return (state == StudentState.checkedOut)? (int)Math.Round(timeSpent.TotalMinutes): 0;
        }   //TimeParticipated
    }   //class Student
}
