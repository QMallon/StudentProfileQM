namespace StudentProfileQM
{
    partial class frmStudentProfile
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTUID = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.dtpExpectedGrad = new System.Windows.Forms.DateTimePicker();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblGradDate = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.btnSaveToText = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpUndergrad = new System.Windows.Forms.GroupBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblselectionError = new System.Windows.Forms.Label();
            this.grpUndergrad.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(100, 40);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(138, 20);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTUID
            // 
            this.txtTUID.Location = new System.Drawing.Point(468, 122);
            this.txtTUID.Name = "txtTUID";
            this.txtTUID.Size = new System.Drawing.Size(100, 20);
            this.txtTUID.TabIndex = 3;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(444, 75);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhonenumber.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(660, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(79, 149);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 20);
            this.txtMajor.TabIndex = 8;
            // 
            // dtpExpectedGrad
            // 
            this.dtpExpectedGrad.Location = new System.Drawing.Point(175, 122);
            this.dtpExpectedGrad.Name = "dtpExpectedGrad";
            this.dtpExpectedGrad.Size = new System.Drawing.Size(200, 20);
            this.dtpExpectedGrad.TabIndex = 9;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(12, 83);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "TUID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone Number";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(12, 156);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(33, 13);
            this.lblMajor.TabIndex = 16;
            this.lblMajor.Text = "Major";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(268, 47);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(355, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(138, 20);
            this.txtFirstName.TabIndex = 17;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(523, 47);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 20;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(622, 40);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(138, 20);
            this.txtMiddleName.TabIndex = 19;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(108, 76);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 21;
            // 
            // lblGradDate
            // 
            this.lblGradDate.AutoSize = true;
            this.lblGradDate.Location = new System.Drawing.Point(12, 129);
            this.lblGradDate.Name = "lblGradDate";
            this.lblGradDate.Size = new System.Drawing.Size(133, 13);
            this.lblGradDate.TabIndex = 22;
            this.lblGradDate.Text = "Expected Graduation Date";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(6, 19);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 23;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(6, 42);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 24;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Location = new System.Drawing.Point(88, 393);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(150, 23);
            this.btnSaveStudent.TabIndex = 26;
            this.btnSaveStudent.Text = "Save Student";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // btnSaveToText
            // 
            this.btnSaveToText.Location = new System.Drawing.Point(320, 393);
            this.btnSaveToText.Name = "btnSaveToText";
            this.btnSaveToText.Size = new System.Drawing.Size(150, 23);
            this.btnSaveToText.TabIndex = 27;
            this.btnSaveToText.Text = "Save to Text file";
            this.btnSaveToText.UseVisualStyleBackColor = true;
            this.btnSaveToText.Click += new System.EventHandler(this.btnSaveToText_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(508, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 23);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(128, 355);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(482, 13);
            this.lblInfo.TabIndex = 29;
            this.lblInfo.Text = "Click save student to save current info for a student. Save and exit will save th" +
    "e students to a textfile ";
            // 
            // grpUndergrad
            // 
            this.grpUndergrad.Controls.Add(this.lblselectionError);
            this.grpUndergrad.Controls.Add(this.rbYes);
            this.grpUndergrad.Controls.Add(this.rbNo);
            this.grpUndergrad.Location = new System.Drawing.Point(408, 156);
            this.grpUndergrad.Name = "grpUndergrad";
            this.grpUndergrad.Size = new System.Drawing.Size(200, 100);
            this.grpUndergrad.TabIndex = 30;
            this.grpUndergrad.TabStop = false;
            this.grpUndergrad.Text = "Are you an Undergraduate?";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Maroon;
            this.lblerror.Location = new System.Drawing.Point(411, 106);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(151, 13);
            this.lblerror.TabIndex = 31;
            this.lblerror.Text = "TUID must be a 9 digit number";
            this.lblerror.Visible = false;
            // 
            // lblselectionError
            // 
            this.lblselectionError.AutoSize = true;
            this.lblselectionError.ForeColor = System.Drawing.Color.Maroon;
            this.lblselectionError.Location = new System.Drawing.Point(9, 72);
            this.lblselectionError.Name = "lblselectionError";
            this.lblselectionError.Size = new System.Drawing.Size(107, 13);
            this.lblselectionError.TabIndex = 32;
            this.lblselectionError.Text = "must select an option";
            this.lblselectionError.Visible = false;
            // 
            // frmStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.grpUndergrad);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveToText);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.lblGradDate);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.dtpExpectedGrad);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTUID);
            this.Controls.Add(this.txtLastName);
            this.Name = "frmStudentProfile";
            this.Text = "Student Profile";
            this.grpUndergrad.ResumeLayout(false);
            this.grpUndergrad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTUID;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.DateTimePicker dtpExpectedGrad;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblGradDate;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Button btnSaveToText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpUndergrad;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblselectionError;
    }
}

