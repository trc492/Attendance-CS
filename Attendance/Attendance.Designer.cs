namespace Attendance
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingLabel = new System.Windows.Forms.Label();
            this.meetingName = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.placeLabel = new System.Windows.Forms.Label();
            this.meetingPlace = new System.Windows.Forms.TextBox();
            this.inStudentsLabel = new System.Windows.Forms.Label();
            this.meetingInfo = new System.Windows.Forms.GroupBox();
            this.endTime = new System.Windows.Forms.ComboBox();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.ComboBox();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inStudentList = new System.Windows.Forms.ComboBox();
            this.checkInButton = new System.Windows.Forms.Button();
            this.checkInGroup = new System.Windows.Forms.GroupBox();
            this.checkOutGroup = new System.Windows.Forms.GroupBox();
            this.outStudentsLabel = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.outStudentList = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            this.meetingInfo.SuspendLayout();
            this.checkInGroup.SuspendLayout();
            this.checkOutGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(530, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(137, 34);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(137, 34);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // meetingLabel
            // 
            this.meetingLabel.AutoSize = true;
            this.meetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingLabel.Location = new System.Drawing.Point(6, 153);
            this.meetingLabel.Name = "meetingLabel";
            this.meetingLabel.Size = new System.Drawing.Size(89, 25);
            this.meetingLabel.TabIndex = 56;
            this.meetingLabel.Text = "Meeting";
            // 
            // meetingName
            // 
            this.meetingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingName.Location = new System.Drawing.Point(121, 150);
            this.meetingName.Name = "meetingName";
            this.meetingName.Size = new System.Drawing.Size(366, 31);
            this.meetingName.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(6, 31);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(57, 25);
            this.dateLabel.TabIndex = 52;
            this.dateLabel.Text = "Date";
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeLabel.Location = new System.Drawing.Point(6, 113);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(66, 25);
            this.placeLabel.TabIndex = 55;
            this.placeLabel.Text = "Place";
            // 
            // meetingPlace
            // 
            this.meetingPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingPlace.Location = new System.Drawing.Point(121, 110);
            this.meetingPlace.Name = "meetingPlace";
            this.meetingPlace.Size = new System.Drawing.Size(366, 31);
            this.meetingPlace.TabIndex = 4;
            // 
            // inStudentsLabel
            // 
            this.inStudentsLabel.AutoSize = true;
            this.inStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStudentsLabel.Location = new System.Drawing.Point(6, 28);
            this.inStudentsLabel.Name = "inStudentsLabel";
            this.inStudentsLabel.Size = new System.Drawing.Size(86, 25);
            this.inStudentsLabel.TabIndex = 58;
            this.inStudentsLabel.Text = "Student";
            // 
            // meetingInfo
            // 
            this.meetingInfo.Controls.Add(this.endTime);
            this.meetingInfo.Controls.Add(this.endTimeLabel);
            this.meetingInfo.Controls.Add(this.startTime);
            this.meetingInfo.Controls.Add(this.startTimeLabel);
            this.meetingInfo.Controls.Add(this.createButton);
            this.meetingInfo.Controls.Add(this.dateTimePicker);
            this.meetingInfo.Controls.Add(this.meetingPlace);
            this.meetingInfo.Controls.Add(this.meetingLabel);
            this.meetingInfo.Controls.Add(this.meetingName);
            this.meetingInfo.Controls.Add(this.dateLabel);
            this.meetingInfo.Controls.Add(this.placeLabel);
            this.meetingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingInfo.Location = new System.Drawing.Point(12, 52);
            this.meetingInfo.Name = "meetingInfo";
            this.meetingInfo.Size = new System.Drawing.Size(503, 255);
            this.meetingInfo.TabIndex = 51;
            this.meetingInfo.TabStop = false;
            this.meetingInfo.Text = "Meeting Info";
            // 
            // endTime
            // 
            this.endTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.FormattingEnabled = true;
            this.endTime.Items.AddRange(new object[] {
            "12:00 am",
            "12:30 am",
            "1:00 am",
            "1:30 am",
            "2:00 am",
            "2:30 am",
            "3:00 am",
            "3:30 am",
            "4:00 am",
            "4:30 am",
            "5:00 am",
            "5:30 am",
            "6:00 am",
            "6:30 am",
            "7:00 am",
            "7:30 am",
            "8:00 am",
            "8:30 am",
            "9:00 am",
            "9:30 am",
            "10:00 am",
            "10:30 am",
            "11:00 am",
            "11:30 am",
            "12:00 pm",
            "12:30 pm",
            "1:00 pm",
            "1:30 pm",
            "2:00 pm",
            "2:30 pm",
            "3:00 pm",
            "3:30 pm",
            "4:00 pm",
            "4:30 pm",
            "5:00 pm",
            "5:30 pm",
            "6:00 pm",
            "6:30 pm",
            "7:00 pm",
            "7:30 pm",
            "8:00 pm",
            "8:30 pm",
            "9:00 pm",
            "9:30 pm",
            "10:00 pm",
            "10:30 pm",
            "11:00 pm",
            "11:30 pm"});
            this.endTime.Location = new System.Drawing.Point(358, 67);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(129, 33);
            this.endTime.TabIndex = 3;
            this.endTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel.Location = new System.Drawing.Point(257, 70);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(103, 25);
            this.endTimeLabel.TabIndex = 54;
            this.endTimeLabel.Text = "End Time";
            // 
            // startTime
            // 
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.FormattingEnabled = true;
            this.startTime.Items.AddRange(new object[] {
            "12:00 am",
            "12:30 am",
            "1:00 am",
            "1:30 am",
            "2:00 am",
            "2:30 am",
            "3:00 am",
            "3:30 am",
            "4:00 am",
            "4:30 am",
            "5:00 am",
            "5:30 am",
            "6:00 am",
            "6:30 am",
            "7:00 am",
            "7:30 am",
            "8:00 am",
            "8:30 am",
            "9:00 am",
            "9:30 am",
            "10:00 am",
            "10:30 am",
            "11:00 am",
            "11:30 am",
            "12:00 pm",
            "12:30 pm",
            "1:00 pm",
            "1:30 pm",
            "2:00 pm",
            "2:30 pm",
            "3:00 pm",
            "3:30 pm",
            "4:00 pm",
            "4:30 pm",
            "5:00 pm",
            "5:30 pm",
            "6:00 pm",
            "6:30 pm",
            "7:00 pm",
            "7:30 pm",
            "8:00 pm",
            "8:30 pm",
            "9:00 pm",
            "9:30 pm",
            "10:00 pm",
            "10:30 pm",
            "11:00 pm",
            "11:30 pm"});
            this.startTime.Location = new System.Drawing.Point(122, 67);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(129, 33);
            this.startTime.TabIndex = 2;
            this.startTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(6, 70);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(110, 25);
            this.startTimeLabel.TabIndex = 53;
            this.startTimeLabel.Text = "Start Time";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(340, 203);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(147, 37);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create &Meeting";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(121, 26);
            this.dateTimePicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(366, 31);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2013, 11, 4, 0, 0, 0, 0);
            // 
            // inStudentList
            // 
            this.inStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStudentList.FormattingEnabled = true;
            this.inStudentList.Location = new System.Drawing.Point(121, 25);
            this.inStudentList.Name = "inStudentList";
            this.inStudentList.Size = new System.Drawing.Size(366, 33);
            this.inStudentList.TabIndex = 7;
            this.inStudentList.SelectedIndexChanged += new System.EventHandler(this.inStudentList_SelectedIndexChanged);
            this.inStudentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(385, 79);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(102, 37);
            this.checkInButton.TabIndex = 8;
            this.checkInButton.Text = "Check-&In";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // checkInGroup
            // 
            this.checkInGroup.Controls.Add(this.inStudentsLabel);
            this.checkInGroup.Controls.Add(this.checkInButton);
            this.checkInGroup.Controls.Add(this.inStudentList);
            this.checkInGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInGroup.Location = new System.Drawing.Point(12, 325);
            this.checkInGroup.Name = "checkInGroup";
            this.checkInGroup.Size = new System.Drawing.Size(503, 131);
            this.checkInGroup.TabIndex = 57;
            this.checkInGroup.TabStop = false;
            this.checkInGroup.Text = "Check-In";
            // 
            // checkOutGroup
            // 
            this.checkOutGroup.Controls.Add(this.outStudentsLabel);
            this.checkOutGroup.Controls.Add(this.checkOutButton);
            this.checkOutGroup.Controls.Add(this.outStudentList);
            this.checkOutGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutGroup.Location = new System.Drawing.Point(12, 471);
            this.checkOutGroup.Name = "checkOutGroup";
            this.checkOutGroup.Size = new System.Drawing.Size(503, 126);
            this.checkOutGroup.TabIndex = 59;
            this.checkOutGroup.TabStop = false;
            this.checkOutGroup.Text = "Check-Out";
            // 
            // outStudentsLabel
            // 
            this.outStudentsLabel.AutoSize = true;
            this.outStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outStudentsLabel.Location = new System.Drawing.Point(6, 28);
            this.outStudentsLabel.Name = "outStudentsLabel";
            this.outStudentsLabel.Size = new System.Drawing.Size(86, 25);
            this.outStudentsLabel.TabIndex = 60;
            this.outStudentsLabel.Text = "Student";
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(385, 73);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(102, 36);
            this.checkOutButton.TabIndex = 10;
            this.checkOutButton.Text = "Check-&Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // outStudentList
            // 
            this.outStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outStudentList.FormattingEnabled = true;
            this.outStudentList.Location = new System.Drawing.Point(121, 25);
            this.outStudentList.Name = "outStudentList";
            this.outStudentList.Size = new System.Drawing.Size(366, 33);
            this.outStudentList.TabIndex = 9;
            this.outStudentList.SelectedIndexChanged += new System.EventHandler(this.outStudentList_SelectedIndexChanged);
            this.outStudentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 608);
            this.Controls.Add(this.checkOutGroup);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.meetingInfo);
            this.Controls.Add(this.checkInGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Attendance";
            this.Text = "Attendance Recorder";
            this.Closed += new System.EventHandler(this.Attendance_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Attendance_Closing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.meetingInfo.ResumeLayout(false);
            this.meetingInfo.PerformLayout();
            this.checkInGroup.ResumeLayout(false);
            this.checkInGroup.PerformLayout();
            this.checkOutGroup.ResumeLayout(false);
            this.checkOutGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label meetingLabel;
        private System.Windows.Forms.TextBox meetingName;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.TextBox meetingPlace;
        private System.Windows.Forms.Label inStudentsLabel;
        private System.Windows.Forms.GroupBox meetingInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox inStudentList;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ComboBox endTime;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.ComboBox startTime;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.GroupBox checkInGroup;
        private System.Windows.Forms.GroupBox checkOutGroup;
        private System.Windows.Forms.Label outStudentsLabel;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.ComboBox outStudentList;
    }
}

