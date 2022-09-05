namespace RegistrationSystem
{
    partial class TestClassForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testAddrBtn = new System.Windows.Forms.Button();
            this.testCourseBtn = new System.Windows.Forms.Button();
            this.testSectionBtn = new System.Windows.Forms.Button();
            this.personBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.instructorBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testAddrBtn
            // 
            this.testAddrBtn.Location = new System.Drawing.Point(46, 73);
            this.testAddrBtn.Name = "testAddrBtn";
            this.testAddrBtn.Size = new System.Drawing.Size(182, 80);
            this.testAddrBtn.TabIndex = 0;
            this.testAddrBtn.Text = "Test Address";
            this.testAddrBtn.UseVisualStyleBackColor = true;
            this.testAddrBtn.Click += new System.EventHandler(this.testAddrBtn_Click);
            // 
            // testCourseBtn
            // 
            this.testCourseBtn.Location = new System.Drawing.Point(292, 73);
            this.testCourseBtn.Name = "testCourseBtn";
            this.testCourseBtn.Size = new System.Drawing.Size(182, 80);
            this.testCourseBtn.TabIndex = 1;
            this.testCourseBtn.Text = "Test Course";
            this.testCourseBtn.UseVisualStyleBackColor = true;
            this.testCourseBtn.Click += new System.EventHandler(this.testCourseBtn_Click);
            // 
            // testSectionBtn
            // 
            this.testSectionBtn.Location = new System.Drawing.Point(543, 73);
            this.testSectionBtn.Name = "testSectionBtn";
            this.testSectionBtn.Size = new System.Drawing.Size(182, 80);
            this.testSectionBtn.TabIndex = 2;
            this.testSectionBtn.Text = "Test Section";
            this.testSectionBtn.UseVisualStyleBackColor = true;
            this.testSectionBtn.Click += new System.EventHandler(this.testSectionBtn_Click);
            // 
            // personBtn
            // 
            this.personBtn.Location = new System.Drawing.Point(46, 223);
            this.personBtn.Name = "personBtn";
            this.personBtn.Size = new System.Drawing.Size(182, 80);
            this.personBtn.TabIndex = 3;
            this.personBtn.Text = "Test Person";
            this.personBtn.UseVisualStyleBackColor = true;
            this.personBtn.Click += new System.EventHandler(this.personBtn_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(543, 227);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(182, 76);
            this.studentBtn.TabIndex = 4;
            this.studentBtn.Text = "Test Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // instructorBtn
            // 
            this.instructorBtn.Location = new System.Drawing.Point(292, 227);
            this.instructorBtn.Name = "instructorBtn";
            this.instructorBtn.Size = new System.Drawing.Size(182, 76);
            this.instructorBtn.TabIndex = 5;
            this.instructorBtn.Text = "Test Instructor";
            this.instructorBtn.UseVisualStyleBackColor = true;
            this.instructorBtn.Click += new System.EventHandler(this.instructorBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Location = new System.Drawing.Point(46, 326);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(182, 76);
            this.scheduleBtn.TabIndex = 6;
            this.scheduleBtn.Text = "Test Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // TestClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scheduleBtn);
            this.Controls.Add(this.instructorBtn);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.personBtn);
            this.Controls.Add(this.testSectionBtn);
            this.Controls.Add(this.testCourseBtn);
            this.Controls.Add(this.testAddrBtn);
            this.Name = "TestClassForm";
            this.Text = "Test Classes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button testAddrBtn;
        private Button testCourseBtn;
        private Button testSectionBtn;
        private Button personBtn;
        private Button studentBtn;
        private Button instructorBtn;
        private Button scheduleBtn;
    }
}