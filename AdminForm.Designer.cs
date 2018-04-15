namespace Hospital_Project
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Billings = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DeletePatient = new System.Windows.Forms.Button();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.btn_DoctorList = new System.Windows.Forms.Button();
            this.btn_MedicineDetails = new System.Windows.Forms.Button();
            this.btn_StaffList = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_wellcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Billings);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_DoctorList);
            this.panel1.Controls.Add(this.btn_MedicineDetails);
            this.panel1.Controls.Add(this.btn_StaffList);
            this.panel1.Location = new System.Drawing.Point(110, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 313);
            this.panel1.TabIndex = 0;
            // 
            // btn_Billings
            // 
            this.btn_Billings.Location = new System.Drawing.Point(213, 231);
            this.btn_Billings.Name = "btn_Billings";
            this.btn_Billings.Size = new System.Drawing.Size(104, 52);
            this.btn_Billings.TabIndex = 15;
            this.btn_Billings.Text = "Billings";
            this.btn_Billings.UseVisualStyleBackColor = true;
            this.btn_Billings.Click += new System.EventHandler(this.btn_Billings_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "Laboratory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Admin Management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btn_DeletePatient);
            this.groupBox1.Controls.Add(this.btn_AddPatient);
            this.groupBox1.Location = new System.Drawing.Point(36, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 103);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Management";
            // 
            // btn_DeletePatient
            // 
            this.btn_DeletePatient.Location = new System.Drawing.Point(177, 33);
            this.btn_DeletePatient.Name = "btn_DeletePatient";
            this.btn_DeletePatient.Size = new System.Drawing.Size(104, 52);
            this.btn_DeletePatient.TabIndex = 9;
            this.btn_DeletePatient.Text = "Delete Exisiting Patient";
            this.btn_DeletePatient.UseVisualStyleBackColor = true;
            this.btn_DeletePatient.Click += new System.EventHandler(this.btn_DeletePatient_Click);
            // 
            // btn_AddPatient
            // 
            this.btn_AddPatient.Location = new System.Drawing.Point(25, 37);
            this.btn_AddPatient.Name = "btn_AddPatient";
            this.btn_AddPatient.Size = new System.Drawing.Size(104, 52);
            this.btn_AddPatient.TabIndex = 8;
            this.btn_AddPatient.Text = "Add new Patient";
            this.btn_AddPatient.UseVisualStyleBackColor = true;
            this.btn_AddPatient.Click += new System.EventHandler(this.btn_AddPatient_Click);
            // 
            // btn_DoctorList
            // 
            this.btn_DoctorList.Location = new System.Drawing.Point(214, 145);
            this.btn_DoctorList.Name = "btn_DoctorList";
            this.btn_DoctorList.Size = new System.Drawing.Size(104, 52);
            this.btn_DoctorList.TabIndex = 11;
            this.btn_DoctorList.Text = "Doctor\'s Management";
            this.btn_DoctorList.UseVisualStyleBackColor = true;
            this.btn_DoctorList.Click += new System.EventHandler(this.btn_DoctorList_Click);
            // 
            // btn_MedicineDetails
            // 
            this.btn_MedicineDetails.Location = new System.Drawing.Point(62, 145);
            this.btn_MedicineDetails.Name = "btn_MedicineDetails";
            this.btn_MedicineDetails.Size = new System.Drawing.Size(104, 52);
            this.btn_MedicineDetails.TabIndex = 10;
            this.btn_MedicineDetails.Text = "Pharmacy Management";
            this.btn_MedicineDetails.UseVisualStyleBackColor = true;
            this.btn_MedicineDetails.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_StaffList
            // 
            this.btn_StaffList.Location = new System.Drawing.Point(372, 47);
            this.btn_StaffList.Name = "btn_StaffList";
            this.btn_StaffList.Size = new System.Drawing.Size(104, 52);
            this.btn_StaffList.TabIndex = 8;
            this.btn_StaffList.Text = "Staff Management";
            this.btn_StaffList.UseVisualStyleBackColor = true;
            this.btn_StaffList.Click += new System.EventHandler(this.btn_StaffList_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(649, 25);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(79, 30);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(480, 34);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(30, 13);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Time";
            // 
            // lbl_wellcome
            // 
            this.lbl_wellcome.AutoSize = true;
            this.lbl_wellcome.Location = new System.Drawing.Point(30, 25);
            this.lbl_wellcome.Name = "lbl_wellcome";
            this.lbl_wellcome.Size = new System.Drawing.Size(128, 13);
            this.lbl_wellcome.TabIndex = 10;
            this.lbl_wellcome.Text = "Wellcome to Admin Portal";
            this.lbl_wellcome.MouseEnter += new System.EventHandler(this.lbl_wellcome_MouseEnter);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 422);
            this.Controls.Add(this.lbl_wellcome);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DoctorList;
        private System.Windows.Forms.Button btn_MedicineDetails;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_StaffList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DeletePatient;
        private System.Windows.Forms.Button btn_AddPatient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_wellcome;
        private System.Windows.Forms.Button btn_Billings;
    }
}