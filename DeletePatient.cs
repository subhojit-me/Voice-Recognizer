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

namespace Hospital_Project
{
    public partial class DeletePatient : Form
    {
        public DeletePatient()
        {
            InitializeComponent();
            this.LoadPatientTable();
        }

        private void LoadPatientTable()
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM hospital.patienttable;", con);
            //MySqlDataReader reader;
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Refreshing table data" + ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DeletePatient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LoadPatientTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    this.txt_patientid.Text = row.Cells["PatientId"].Value.ToString();
                    this.txt_patientname.Text = row.Cells["PatientName"].Value.ToString();
                    this.txt_address.Text = row.Cells["PatientAddress"].Value.ToString();
                    this.txt_bloodgroup.Text = row.Cells["PatientBloodGroup"].Value.ToString();
                    this.txt_mobile.Text = row.Cells["PatientMobile"].Value.ToString();
                    this.txt_age.Text = row.Cells["PatientAge"].Value.ToString();

                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error in table cell content click"+ex.ToString() );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.ShowDialog();
        }

        private void btn_discharge_Click(object sender, EventArgs e)
        {
            //discharge patient means deleting the data from the patient table database

            String driver = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM hospital.patienttable WHERE PatientId='"+this.txt_patientid.Text +"'; ", con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Selected Patient data deleted");
                while(reader.Read())
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error while discharging patient"+ex.ToString() );
            }
            this.LoadPatientTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "UPDATE hospital.patienttable SET PatientName= '" +this.txt_patientname.Text +"', PatientAge= '" +this.txt_age.Text+
                  "', PatientMobile= " + this.txt_mobile.Text+", PatientAddress= '" +this.txt_address.Text +"' WHERE PatientId= '" +this.txt_patientid.Text+"'; ";

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Selected Patient data updated");
                while (reader.Read())
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error while updating error table " + ex.ToString());
            }
            this.LoadPatientTable();
        }
    }
}
