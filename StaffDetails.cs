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
    public partial class StaffDetails : Form
    {
        public StaffDetails()
        {
            InitializeComponent();
            this.LoadStaffTable();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.LoadStaffTable();
        }

        private void LoadStaffTable()
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM hospital.stafftable;", con);
            
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.ShowDialog();
        }

        private void btn_AddNewStaffData_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query ="INSERT INTO hospital.stafftable (`StaffName`, `StaffDesignation`, `StaffAddress`, `StaffSalary`) " +
                "VALUES ('"+ this.txt_staffname.Text + "', '" + this.txt_staffdesign.Text + "', '" + this.txt_staffaddress.Text + "', '" + this.txt_staffsalary.Text + "'); ";

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Staff Data Added");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding data to databse" + ex.ToString());
            }
            this.LoadStaffTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    this.txt_staffid.Text = row.Cells["StaffId"].Value.ToString();
                    this.txt_staffname.Text = row.Cells["StaffName"].Value.ToString();
                    this.txt_staffsalary.Text = row.Cells["StaffSalary"].Value.ToString();
                    this.txt_staffaddress.Text = row.Cells["StaffAddress"].Value.ToString();
                    this.txt_staffdesign.Text = row.Cells["StaffDesignation"].Value.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in datagrid event" + ex.ToString());
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.txt_staffid.Text = "";
            this.txt_staffname.Text = "";
            this.txt_staffsalary.Text = "";
            this.txt_staffaddress.Text = "";
            this.txt_staffdesign.Text = "";
        }

        private void btn_UpdateStaffData_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "UPDATE `hospital`.`stafftable` SET `StaffId`='" + this.txt_staffid.Text + "', `StaffName`='" + this.txt_staffname.Text +
                "', `StaffDesignation`='" + this.txt_staffdesign.Text + "', `StaffAddress`='" + this.txt_staffaddress.Text + "', `StaffSalary`='" + this.txt_staffsalary.Text +
                "' WHERE `StaffId`='" + this.txt_staffid.Text + "';";

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Staff Data Updated");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding data to databse" + ex.ToString());
            }
            this.LoadStaffTable();
        }

        private void btn_DeleteStaffData_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "DELETE FROM hospital.stafftable WHERE StaffId= '"+this.txt_staffid.Text+"'; ";

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Staff Data Deleted");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding data to databse" + ex.ToString());
            }
            this.LoadStaffTable();
        }
    }
}
