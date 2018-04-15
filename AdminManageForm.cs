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
    public partial class AdminManageForm : Form
    {
        public AdminManageForm()
        {
            InitializeComponent();
            this.LoadAdminTable();
        }

        private void btn_createAdmin_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "INSERT INTO `hospital`.`admintable` (`AdminLoginId`, `AdminName`, `AdminPassword`) " +
                "VALUES ('" + this.txt_id.Text + "', '" + this.txt_name.Text + "', '" + this.txt_password.Text + "'); ";
            //MessageBox.Show(query);

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("New Admin Added");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding data to databse" + ex.ToString());
            }
            this.LoadAdminTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoadAdminTable()
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM hospital.admintable;", con);

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
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    this.txt_id.Text = row.Cells["AdminLoginId"].Value.ToString();
                    this.txt_name.Text = row.Cells["AdminName"].Value.ToString();
                    this.txt_password.Text = row.Cells["AdminPassword"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in datagrid event" + ex.ToString());
                }
                this.LoadAdminTable();
            }
        }

        private void btn_updateData_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "UPDATE hospital.admintable SET `AdminLoginid`='" + this.txt_id.Text + "', `AdminName`='" + this.txt_name.Text + "', `Adminpassword`='" +
                this.txt_password.Text + "' WHERE `AdminLoginid`= '" + this.txt_id.Text + "'; ";

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Admin data updated");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Updating data to databse" + ex.ToString());
            }
            this.LoadAdminTable();
        }

        private void btn_deleteAdmin_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "DELETE FROM `hospital`.`admintable` WHERE `AdminLoginid`='" + this.txt_id.Text + "'; ";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Admin Data Deleted");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Updating data to databse" + ex.ToString());
            }
            this.LoadAdminTable();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txt_id.Text = "";
            this.txt_name.Text = "";
            this.txt_password.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.ShowDialog();
        }
    }
}
