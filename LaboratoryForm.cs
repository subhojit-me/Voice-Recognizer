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
    public partial class LaboratoryForm : Form
    {
        public LaboratoryForm()
        {
            InitializeComponent();
            this.loadLaboratoryTable();
        }

        private void loadLaboratoryTable()
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
                dataGridView1.DataSource = bs;
                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Refreshing table data" + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    this.txt_id.Text = row.Cells["Id"].Value.ToString();
                    this.txt_name.Text = row.Cells["Name"].Value.ToString();
                    this.txt_age.Text = row.Cells["Age"].Value.ToString();
                    this.comboBox_gender.Text = row.Cells["Gender"].Value.ToString();
                    this.comboBox_test.Text = row.Cells["TestType"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in datagrid event" + ex.ToString());
                }
                this.loadLaboratoryTable();
            }
        }

        private void btn_AddLabData_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "INSERT INTO hospital.laboratory (`Name`, `Age`, `TestType`, `Gender`) " +
                "VALUES ('" + this.txt_name.Text + "', '" + this.txt_age.Text + "', '" + this.comboBox_test.Text + "', '"+
                this.comboBox_gender.Text+"'); ";

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("New Test Data Added");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding data to databse" + ex.ToString());
            }
            this.loadLaboratoryTable();
        }

        private void btnn_UpdateLabData_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "UPDATE `hospital`.`laboratory` SET `Name`='"+this.txt_name.Text+ "', `TestType`='"+this.comboBox_test.Text+"', " +
                "`Gender`='"+this.comboBox_gender.Text+ "', `Age`='"+this.txt_age.Text+"' WHERE `Id`='"+this.txt_id.Text+"'; ";

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("New Test Data Added");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding data to databse" + ex.ToString());
            }
            this.loadLaboratoryTable();
        }

        private void btn_DeleteMedicine_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM `hospital`.`laboratory` WHERE `Id`='" + this.txt_id.Text + "'; ";
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Labpratpry Data has Deleted");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding data to databse" + ex.ToString());
            }
            this.loadLaboratoryTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txt_id.Text = "";
            this.txt_name.Text = "";
            this.txt_age.Text = "";
            this.comboBox_gender.Text = "";
            this.comboBox_test.Text = "";

        }
    }
}
