
namespace BSM
{
    partial class ManageSellerEmp
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
            this.ManageSellerGroupBox = new System.Windows.Forms.GroupBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.dateTimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ManageSellerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageSellerGroupBox
            // 
            this.ManageSellerGroupBox.Controls.Add(this.userNameTextBox);
            this.ManageSellerGroupBox.Controls.Add(this.button1);
            this.ManageSellerGroupBox.Controls.Add(this.comboBoxBloodGroup);
            this.ManageSellerGroupBox.Controls.Add(this.label4);
            this.ManageSellerGroupBox.Controls.Add(this.labelName);
            this.ManageSellerGroupBox.Controls.Add(this.idTextBox);
            this.ManageSellerGroupBox.Controls.Add(this.radioButtonFemale);
            this.ManageSellerGroupBox.Controls.Add(this.nameTextBox);
            this.ManageSellerGroupBox.Controls.Add(this.radioButtonMale);
            this.ManageSellerGroupBox.Controls.Add(this.labelStudentID);
            this.ManageSellerGroupBox.Controls.Add(this.dateTimePickerDoB);
            this.ManageSellerGroupBox.Controls.Add(this.labelEmail);
            this.ManageSellerGroupBox.Controls.Add(this.label2);
            this.ManageSellerGroupBox.Controls.Add(this.emailTextBox);
            this.ManageSellerGroupBox.Controls.Add(this.label5);
            this.ManageSellerGroupBox.Controls.Add(this.label3);
            this.ManageSellerGroupBox.Controls.Add(this.label1);
            this.ManageSellerGroupBox.Controls.Add(this.passwordTextBox);
            this.ManageSellerGroupBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSellerGroupBox.Location = new System.Drawing.Point(16, 85);
            this.ManageSellerGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageSellerGroupBox.Name = "ManageSellerGroupBox";
            this.ManageSellerGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageSellerGroupBox.Size = new System.Drawing.Size(527, 576);
            this.ManageSellerGroupBox.TabIndex = 30;
            this.ManageSellerGroupBox.TabStop = false;
            this.ManageSellerGroupBox.Text = "Manage Seller";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(200, 151);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(281, 31);
            this.userNameTextBox.TabIndex = 55;
            this.userNameTextBox.Leave += new System.EventHandler(this.userNameTextBox_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(199, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 54;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxBloodGroup
            // 
            this.comboBoxBloodGroup.FormattingEnabled = true;
            this.comboBoxBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(201, 437);
            this.comboBoxBloodGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(281, 32);
            this.comboBoxBloodGroup.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(120, 110);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 25);
            this.labelName.TabIndex = 37;
            this.labelName.Text = "Name";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(199, 59);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(283, 31);
            this.idTextBox.TabIndex = 38;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(233, 391);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(95, 29);
            this.radioButtonFemale.TabIndex = 51;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(200, 107);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(281, 31);
            this.nameTextBox.TabIndex = 39;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(233, 357);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(76, 29);
            this.radioButtonMale.TabIndex = 52;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(80, 160);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(109, 25);
            this.labelStudentID.TabIndex = 40;
            this.labelStudentID.Text = "User Name";
            // 
            // dateTimePickerDoB
            // 
            this.dateTimePickerDoB.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDoB.Location = new System.Drawing.Point(200, 306);
            this.dateTimePickerDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDoB.Name = "dateTimePickerDoB";
            this.dateTimePickerDoB.Size = new System.Drawing.Size(281, 31);
            this.dateTimePickerDoB.TabIndex = 50;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(116, 203);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 25);
            this.labelEmail.TabIndex = 43;
            this.labelEmail.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Gender";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(200, 199);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(281, 31);
            this.emailTextBox.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Blood Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Date of Birth";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(200, 247);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(281, 31);
            this.passwordTextBox.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(212, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 43);
            this.label6.TabIndex = 31;
            this.label6.Text = "BOOKAHOLIC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(15, 11);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(76, 38);
            this.BackButton.TabIndex = 55;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManageSellerEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 676);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ManageSellerGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageSellerEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSellerEmp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageSellerEmp_FormClosing);
            this.Load += new System.EventHandler(this.ManageSellerEmp_Load);
            this.ManageSellerGroupBox.ResumeLayout(false);
            this.ManageSellerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ManageSellerGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoB;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
    }
}