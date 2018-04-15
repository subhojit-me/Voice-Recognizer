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
    public partial class DoctorDetailsfromAdmin : Form
    {
        public DoctorDetailsfromAdmin()
        {
            InitializeComponent();
            LoadDoctorTable();
        }

        private void LoadDoctorTable()
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM hospital.doctortable;", con);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    this.txt_doctorid.Text = row.Cells["DoctorId"].Value.ToString();
                    this.txtname.Text = row.Cells["DoctorName"].Value.ToString();
                    this.txt_address.Text = row.Cells["DoctorAddress"].Value.ToString();
                    this.txt_specialized.Text= row.Cells["DoctorSpecility"].Value.ToString();
                    this.txt_doctorpassword.Text= row.Cells["Password"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in datagrid event" + ex.ToString());
                }

            }
        }

        private void brn_addNew_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "INSERT INTO hospital.doctortable (`DoctorId`, `DoctorName`, `DoctorSpecility`, `Password`, `DoctorAddress`) " +
            "VALUES ('"+this.txt_doctorid.Text+"', '"+this.txtname.Text+"', '"+this.txt_specialized.Text + "', '"+this.txt_doctorpassword.Text+"', '"+this.txt_address.Text + "'); ";

           // MessageBox.Show(query);

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("New medicine Data Added");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding data to databse" + ex.ToString());
            }
            this.LoadDoctorTable();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "UPDATE hospital.doctortable SET `DoctorId`='" + this.txt_doctorid.Text + "', `DoctorName`='" + this.txtname.Text +
                "', `DoctorSpecility`='"+this.txt_specialized.Text+"', `Password`='"+this.txt_doctorpassword.Text +
                "', `DoctorAddress`='"+ this.txt_address.Text + "' WHERE `DoctorId`='" + this.txt_doctorid.Text + "'; ";

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Doctor Data Updated");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating data to databse" + ex.ToString());
            }
            this.LoadDoctorTable();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "DELETE FROM hospital.doctortable WHERE `DoctorId`= '" + this.txt_doctorid.Text + "'; ";


            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Doctor Data Deleted");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Deleting data from databse" + ex.ToString());
            }
            this.LoadDoctorTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadDoctorTable();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.ShowDialog();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txtname.Text = "";
            this.txt_address.Text = "";
            this.txt_doctorid.Text = "";
            this.txt_doctorpassword.Text = "";
            this.txt_specialized.Text = "";
        }
    }
}
