namespace Hospital_Project
{
    partial class StaffDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_AddNewStaffData = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_DeleteStaffData = new System.Windows.Forms.Button();
            this.btn_UpdateStaffData = new System.Windows.Forms.Button();
            this.txt_staffaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_staffsalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_staffdesign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_staffname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_staffid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(274, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Staff Details";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(223, 19);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(120, 29);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(531, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_AddNewStaffData);
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.btn_DeleteStaffData);
            this.groupBox2.Controls.Add(this.btn_UpdateStaffData);
            this.groupBox2.Controls.Add(this.txt_staffaddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_staffsalary);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_staffdesign);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_staffname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_staffid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Staff Details";
            // 
            // btn_AddNewStaffData
            // 
            this.btn_AddNewStaffData.Location = new System.Drawing.Point(24, 221);
            this.btn_AddNewStaffData.Name = "btn_AddNewStaffData";
            this.btn_AddNewStaffData.Size = new System.Drawing.Size(82, 36);
            this.btn_AddNewStaffData.TabIndex = 13;
            this.btn_AddNewStaffData.Text = "Add New Staff";
            this.btn_AddNewStaffData.UseVisualStyleBackColor = true;
            this.btn_AddNewStaffData.Click += new System.EventHandler(this.btn_AddNewStaffData_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(131, 278);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(82, 36);
            this.btn_Reset.TabIndex = 12;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_DeleteStaffData
            // 
            this.btn_DeleteStaffData.Location = new System.Drawing.Point(24, 278);
            this.btn_DeleteStaffData.Name = "btn_DeleteStaffData";
            this.btn_DeleteStaffData.Size = new System.Drawing.Size(82, 36);
            this.btn_DeleteStaffData.TabIndex = 11;
            this.btn_DeleteStaffData.Text = "Delete Staff Data";
            this.btn_DeleteStaffData.UseVisualStyleBackColor = true;
            this.btn_DeleteStaffData.Click += new System.EventHandler(this.btn_DeleteStaffData_Click);
            // 
            // btn_UpdateStaffData
            // 
            this.btn_UpdateStaffData.Location = new System.Drawing.Point(131, 221);
            this.btn_UpdateStaffData.Name = "btn_UpdateStaffData";
            this.btn_UpdateStaffData.Size = new System.Drawing.Size(82, 36);
            this.btn_UpdateStaffData.TabIndex = 10;
            this.btn_UpdateStaffData.Text = "Update Staff Data";
            this.btn_UpdateStaffData.UseVisualStyleBackColor = true;
            this.btn_UpdateStaffData.Click += new System.EventHandler(this.btn_UpdateStaffData_Click);
            // 
            // txt_staffaddress
            // 
            this.txt_staffaddress.Location = new System.Drawing.Point(89, 133);
            this.txt_staffaddress.Name = "txt_staffaddress";
            this.txt_staffaddress.Size = new System.Drawing.Size(125, 20);
            this.txt_staffaddress.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // txt_staffsalary
            // 
            this.txt_staffsalary.Location = new System.Drawing.Point(88, 165);
            this.txt_staffsalary.Name = "txt_staffsalary";
            this.txt_staffsalary.Size = new System.Drawing.Size(125, 20);
            this.txt_staffsalary.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salary";
            // 
            // txt_staffdesign
            // 
            this.txt_staffdesign.Location = new System.Drawing.Point(89, 103);
            this.txt_staffdesign.Name = "txt_staffdesign";
            this.txt_staffdesign.Size = new System.Drawing.Size(125, 20);
            this.txt_staffdesign.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Designation";
            // 
            // txt_staffname
            // 
            this.txt_staffname.Location = new System.Drawing.Point(89, 75);
            this.txt_staffname.Name = "txt_staffname";
            this.txt_staffname.Size = new System.Drawing.Size(125, 20);
            this.txt_staffname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txt_staffid
            // 
            this.txt_staffid.Location = new System.Drawing.Point(89, 44);
            this.txt_staffid.Name = "txt_staffid";
            this.txt_staffid.Size = new System.Drawing.Size(125, 20);
            this.txt_staffid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Id";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(23, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 449);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StaffDetails";
            this.Text = "Staff Details";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AddNewStaffData;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_DeleteStaffData;
        private System.Windows.Forms.Button btn_UpdateStaffData;
        private System.Windows.Forms.TextBox txt_staffaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_staffsalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_staffdesign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_staffname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_staffid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
    }
}