namespace Hospital_Project
{
    partial class LaboratoryForm
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.btn_DeleteMedicine = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnn_UpdateLabData = new System.Windows.Forms.Button();
            this.btn_AddLabData = new System.Windows.Forms.Button();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_test = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.btn_DeleteMedicine);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnn_UpdateLabData);
            this.groupBox1.Controls.Add(this.btn_AddLabData);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_test);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_gender);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Test Datas";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(105, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(161, 20);
            this.txt_id.TabIndex = 26;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(17, 26);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 25;
            this.Id.Text = "Id";
            // 
            // btn_DeleteMedicine
            // 
            this.btn_DeleteMedicine.Location = new System.Drawing.Point(20, 286);
            this.btn_DeleteMedicine.Name = "btn_DeleteMedicine";
            this.btn_DeleteMedicine.Size = new System.Drawing.Size(93, 37);
            this.btn_DeleteMedicine.TabIndex = 24;
            this.btn_DeleteMedicine.Text = "Delete Existing Data";
            this.btn_DeleteMedicine.UseVisualStyleBackColor = true;
            this.btn_DeleteMedicine.Click += new System.EventHandler(this.btn_DeleteMedicine_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(172, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 37);
            this.button4.TabIndex = 23;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnn_UpdateLabData
            // 
            this.btnn_UpdateLabData.Location = new System.Drawing.Point(172, 212);
            this.btnn_UpdateLabData.Name = "btnn_UpdateLabData";
            this.btnn_UpdateLabData.Size = new System.Drawing.Size(94, 51);
            this.btnn_UpdateLabData.TabIndex = 22;
            this.btnn_UpdateLabData.Text = "Update Exisiting Data";
            this.btnn_UpdateLabData.UseVisualStyleBackColor = true;
            this.btnn_UpdateLabData.Click += new System.EventHandler(this.btnn_UpdateLabData_Click);
            // 
            // btn_AddLabData
            // 
            this.btn_AddLabData.Location = new System.Drawing.Point(20, 212);
            this.btn_AddLabData.Name = "btn_AddLabData";
            this.btn_AddLabData.Size = new System.Drawing.Size(93, 51);
            this.btn_AddLabData.TabIndex = 20;
            this.btn_AddLabData.Text = "Add New Test data";
            this.btn_AddLabData.UseVisualStyleBackColor = true;
            this.btn_AddLabData.Click += new System.EventHandler(this.btn_AddLabData_Click);
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(105, 90);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(50, 20);
            this.txt_age.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // comboBox_test
            // 
            this.comboBox_test.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_test.FormattingEnabled = true;
            this.comboBox_test.Items.AddRange(new object[] {
            "X-Ray",
            "Blood-Test",
            "Urine",
            "E.C.G.",
            "M.R.I."});
            this.comboBox_test.Location = new System.Drawing.Point(105, 171);
            this.comboBox_test.Name = "comboBox_test";
            this.comboBox_test.Size = new System.Drawing.Size(121, 21);
            this.comboBox_test.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender"});
            this.comboBox_gender.Location = new System.Drawing.Point(105, 128);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(121, 21);
            this.comboBox_gender.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(105, 53);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(161, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(335, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 340);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existing Staff Datas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(469, 259);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Table";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LaboratoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LaboratoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaboratoryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnn_UpdateLabData;
        private System.Windows.Forms.Button btn_AddLabData;
        private System.Windows.Forms.Button btn_DeleteMedicine;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label Id;
    }
}