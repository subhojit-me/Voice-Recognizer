using MySql.Data.MySqlClient;
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
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace Hospital_Project
{
    public partial class Biling : Form
    {
        public Biling()
        {
            InitializeComponent();
            this.LoadAdmittedPatientTable();
            this.LoadOutdoorTable();
            timer1.Start();
        }

        private void LoadAdmittedPatientTable()
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM hospital.patienttable;", con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                this.admittedTable.DataSource = bs;
                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Refreshing table data" + ex.ToString());
            }
        }

        private void LoadOutdoorTable()
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM hospital.laboratory;", con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                this.outdoorTable.DataSource = bs;
                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Refreshing table data" + ex.ToString());
            }
        }

        private void Biling_Load(object sender, EventArgs e)
        {

        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.txt_Id.Text = "";
            this.txt_labCharge.Text = "";
            this.txt_name.Text = "";
            this.txt_other.Text = "";
            this.txt_pharmacycharge.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lbl_time.Text = dt.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*
             * Put drawImage() hre to give the Logo and address image of hospital
             */

            e.Graphics.DrawString("Patient Id = " + this.txt_Id.Text, new System.Drawing.Font("Times New Roman", 12, FontStyle.Regular),
                Brushes.Black, new Point(80, 100));

            e.Graphics.DrawString("Patient Name = " + this.txt_name.Text, new System.Drawing.Font("Times New Roman",12,FontStyle.Regular),
                Brushes.Black, new Point(80, 140) );

            e.Graphics.DrawString("Invoice Date and time= " + DateTime.Now.ToString(), new System.Drawing.Font("Times New Roman", 12, FontStyle.Regular),
                Brushes.Black, new Point(80, 180));

            e.Graphics.DrawString("Lab Charge = " + this.txt_labCharge.Text, new System.Drawing.Font("Times New Roman", 12, FontStyle.Regular),
                Brushes.Black, new Point(80, 220));

            e.Graphics.DrawString("Pharmacy Charge = " + this.txt_pharmacycharge.Text, new System.Drawing.Font("Times New Roman", 12, FontStyle.Regular),
                Brushes.Black, new Point(80, 260));

            e.Graphics.DrawString("Other Charge = " + this.txt_other.Text, new System.Drawing.Font("Times New Roman", 12, FontStyle.Regular),
                Brushes.Black, new Point(80, 300));

            e.Graphics.DrawString("Signature ", new System.Drawing.Font("Times New Roman", 18, FontStyle.Underline),
                Brushes.Black, new Point(600, 800));
        }
    }
}
