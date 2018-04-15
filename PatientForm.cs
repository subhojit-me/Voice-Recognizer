using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
            this.LoadPatienttbale();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            //mistaken event
        }  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //MessageBox.Show("Row= " + e.RowIndex + "Coloumn Index= " + e.ColumnIndex);
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    //MessageBox.Show("Cel content click event is working");

                    this.txt_id.Text = row.Cells["PatientId"].Value.ToString();
                    this.txt_fullname.Text = row.Cells["PatientName"].Value.ToString();
                    this.txt_age.Text = row.Cells["PatientAge"].Value.ToString();
                    this.txt_mobile.Text = row.Cells["PatientMobile"].Value.ToString();
                    this.txt_bloodgroup.Text = row.Cells["PatientBloodGroup"].Value.ToString();
                    this.txt_allotedbed.Text = row.Cells["BedAlloted"].Value.ToString();
                    this.txt_allotedstaff.Text = row.Cells["StaffId"].Value.ToString();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error in cell content click event"+ex.ToString() );
            }
            this.LoadPatienttbale();
        }

        private void LoadPatienttbale()
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

        private void btnRefreshTable_Click_1(object sender, EventArgs e)
        {
            //refresh burron action event
            this.LoadPatienttbale();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //log out button acion event
            DoctorsForm df = new DoctorsForm();
            this.Hide();
            df.ShowDialog();
        }
    }
}
