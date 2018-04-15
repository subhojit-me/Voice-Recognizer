namespace Hospital_Project
{
    partial class PatientForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_allotedstaff = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_allotedbed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bloodgroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefreshTable);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(240, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 364);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(206, 11);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(184, 29);
            this.btnRefreshTable.TabIndex = 3;
            this.btnRefreshTable.Text = "Refresh Table";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(536, 283);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_allotedstaff);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_allotedbed);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_mobile);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_bloodgroup);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_age);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_fullname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 364);
            this.panel2.TabIndex = 1;
            // 
            // txt_allotedstaff
            // 
            this.txt_allotedstaff.Location = new System.Drawing.Point(83, 207);
            this.txt_allotedstaff.Name = "txt_allotedstaff";
            this.txt_allotedstaff.ReadOnly = true;
            this.txt_allotedstaff.Size = new System.Drawing.Size(100, 20);
            this.txt_allotedstaff.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alloted Staff";
            // 
            // txt_allotedbed
            // 
            this.txt_allotedbed.Location = new System.Drawing.Point(83, 172);
            this.txt_allotedbed.Name = "txt_allotedbed";
            this.txt_allotedbed.ReadOnly = true;
            this.txt_allotedbed.Size = new System.Drawing.Size(100, 20);
            this.txt_allotedbed.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alloteb Bed";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(83, 137);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.ReadOnly = true;
            this.txt_mobile.Size = new System.Drawing.Size(100, 20);
            this.txt_mobile.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mobile";
            // 
            // txt_bloodgroup
            // 
            this.txt_bloodgroup.Location = new System.Drawing.Point(83, 104);
            this.txt_bloodgroup.Name = "txt_bloodgroup";
            this.txt_bloodgroup.ReadOnly = true;
            this.txt_bloodgroup.Size = new System.Drawing.Size(100, 20);
            this.txt_bloodgroup.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blood Group";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(83, 74);
            this.txt_age.Name = "txt_age";
            this.txt_age.ReadOnly = true;
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(83, 50);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.ReadOnly = true;
            this.txt_fullname.Size = new System.Drawing.Size(100, 20);
            this.txt_fullname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(83, 24);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_allotedstaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_allotedbed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bloodgroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}