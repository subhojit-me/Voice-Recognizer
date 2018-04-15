using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class MedicineForm : Form
    {
        public MedicineForm()
        {
            InitializeComponent();
            this.LoadMedicineTable();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadMedicineTable()
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM hospital.medicinetable;", con);
            
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.LoadMedicineTable();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //log out button event
            AdminForm af = new AdminForm();
            this.Hide();
            af.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //table on click event
            try
            {
                MessageBox.Show("Row= " + e.RowIndex + "Coloumn Index= " + e.ColumnIndex);
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    MessageBox.Show("Cel content click event is working");

                    this.txt_medicineid.Text = row.Cells["MedicineId"].Value.ToString();
                    this.txt_medicinename.Text = row.Cells["MedicineName"].Value.ToString();
                    this.txt_supplier.Text = row.Cells["MedicineSupplier"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Row index is less then 1 = "+e.RowIndex);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error in cell contebt click event"+ex.ToString() );
            }
            this.LoadMedicineTable();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    this.txt_medicineid.Text = row.Cells["MedicineId"].Value.ToString();
                    this.txt_medicinename.Text = row.Cells["MedicineName"].Value.ToString();
                    this.txt_supplier.Text = row.Cells["MedicineSupplier"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in datagrid event" + ex.ToString());
                }
                this.LoadMedicineTable();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.LoadMedicineTable();
        }

        private void Btn_addMedicine_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "INSERT INTO hospital.medicinetable (`MedicineId`, `MedicineName`, `MedicineSupplier`) " +
                "VALUES ('"+this.txt_medicineid.Text+"', '"+this.txt_medicinename.Text+"', '"+this.txt_supplier.Text+"'); ";
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
            this.LoadMedicineTable();
        }

        private void btn_UpdateMedicine_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "UPDATE hospital.medicinetable SET `MedicineId`='" + this.txt_medicineid.Text + "', `MedicineName`='" + this.txt_medicinename.Text + "', `MedicineSupplier`='" +
                this.txt_supplier.Text + "' WHERE `MedicineId`= '" + this.txt_medicineid.Text + "'; ";

            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Medicine data updated");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Updating data to databse" + ex.ToString());
            }
            this.LoadMedicineTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txt_medicineid.Text = "";
            this.txt_medicinename.Text = "";
            this.txt_supplier.Text = "";
        }

        private void btn_DeleteMedicine_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query = "DELETE FROM hospital.medicinetable WHERE `MedicineId`='"+this.txt_medicineid.Text+"'; ";
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Medicine data Deleted");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Deleting data from databse" + ex.ToString());
            }
            this.LoadMedicineTable();
        }
    }
}
