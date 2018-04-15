namespace Hospital_Project
{
    partial class MedicineForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteMedicine = new System.Windows.Forms.Button();
            this.btn_UpdateMedicine = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_addMedicine = new System.Windows.Forms.Button();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_medicinename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_medicineid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(274, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Madicine in Stock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(469, 259);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DeleteMedicine);
            this.groupBox2.Controls.Add(this.btn_UpdateMedicine);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btn_addMedicine);
            this.groupBox2.Controls.Add(this.txt_supplier);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_medicinename);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_medicineid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(23, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 323);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add/Update/Delete medicine";
            // 
            // btn_DeleteMedicine
            // 
            this.btn_DeleteMedicine.Location = new System.Drawing.Point(13, 262);
            this.btn_DeleteMedicine.Name = "btn_DeleteMedicine";
            this.btn_DeleteMedicine.Size = new System.Drawing.Size(75, 37);
            this.btn_DeleteMedicine.TabIndex = 19;
            this.btn_DeleteMedicine.Text = "Delete Medicine Data";
            this.btn_DeleteMedicine.UseVisualStyleBackColor = true;
            this.btn_DeleteMedicine.Click += new System.EventHandler(this.btn_DeleteMedicine_Click);
            // 
            // btn_UpdateMedicine
            // 
            this.btn_UpdateMedicine.Location = new System.Drawing.Point(126, 204);
            this.btn_UpdateMedicine.Name = "btn_UpdateMedicine";
            this.btn_UpdateMedicine.Size = new System.Drawing.Size(75, 37);
            this.btn_UpdateMedicine.TabIndex = 18;
            this.btn_UpdateMedicine.Text = "Update Medicine";
            this.btn_UpdateMedicine.UseVisualStyleBackColor = true;
            this.btn_UpdateMedicine.Click += new System.EventHandler(this.btn_UpdateMedicine_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 17;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_addMedicine
            // 
            this.btn_addMedicine.Location = new System.Drawing.Point(13, 204);
            this.btn_addMedicine.Name = "btn_addMedicine";
            this.btn_addMedicine.Size = new System.Drawing.Size(75, 37);
            this.btn_addMedicine.TabIndex = 16;
            this.btn_addMedicine.Text = "Add New Medicine";
            this.btn_addMedicine.UseVisualStyleBackColor = true;
            this.btn_addMedicine.Click += new System.EventHandler(this.Btn_addMedicine_Click);
            // 
            // txt_supplier
            // 
            this.txt_supplier.Location = new System.Drawing.Point(96, 104);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(114, 20);
            this.txt_supplier.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Supplier";
            // 
            // txt_medicinename
            // 
            this.txt_medicinename.Location = new System.Drawing.Point(96, 64);
            this.txt_medicinename.Name = "txt_medicinename";
            this.txt_medicinename.Size = new System.Drawing.Size(114, 20);
            this.txt_medicinename.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Medicine Name";
            // 
            // txt_medicineid
            // 
            this.txt_medicineid.Location = new System.Drawing.Point(96, 24);
            this.txt_medicineid.Name = "txt_medicineid";
            this.txt_medicineid.Size = new System.Drawing.Size(114, 20);
            this.txt_medicineid.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Medicine Id";
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_DeleteMedicine;
        private System.Windows.Forms.Button btn_UpdateMedicine;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_addMedicine;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_medicinename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_medicineid;
        private System.Windows.Forms.Label label1;
    }
}