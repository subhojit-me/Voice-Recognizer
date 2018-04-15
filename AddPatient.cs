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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
            this.LoadPatientTable();
        }   //constructor

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

        private void AddPatient_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Back button action performmed
            AdminForm af = new AdminForm();
            this.Hide();
            af.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LoadPatientTable();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txt_address.Text = "";
            this.txt_age.Text = "";
            this.txt_allotedbed.Text = "";
            this.txt_allotestaff.Text = "";
            this.txt_allotedoctor.Text = "";
            this.txt_bloodgroup.Text = "";
            this.txt_mobile.Text = "";
            this.txt_patientname.Text = "";
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            String driver = "datasource=localhost;port=3306;username=root;password=root";
            String query ="INSERT INTO hospital.patienttable (`PatientName`, `PatientAge`, `PatientBloodGroup`, `PatientMobile`, `PatientAddress`, " +
                "`BedAlloted`, `DoctorId`, `StaffId`) VALUES('"+ this.txt_patientname.Text + "', '"+this.txt_age.Text+"', '"+this.txt_bloodgroup.Text + "', " +
                "'"+this.txt_mobile.Text + "', '"+this.txt_address.Text + "', '"+this.txt_allotedbed.Text + "', '"+this.txt_allotedoctor.Text + 
                "', '"+this.txt_allotestaff.Text + "'); ";
            
            MySqlConnection con = new MySqlConnection(driver);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("patient Data Added");
                while (reader.Read())
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error while adding data to databse"+ ex.ToString() );
            }
            this.LoadPatientTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    this.txt_address.Text = row.Cells["PatientAddress"].Value.ToString();
                    this.txt_age.Text= row.Cells["PatientAge"].Value.ToString();
                    this.txt_allotedbed.Text = row.Cells["BedAlloted"].Value.ToString();
                    this.txt_allotedoctor.Text = row.Cells["Doctorid"].Value.ToString();
                    this.txt_allotestaff.Text = row.Cells["StaffId"].Value.ToString();
                    this.txt_bloodgroup.Text = row.Cells["PatientBloodGroup"].Value.ToString();
                    this.txt_mobile.Text = row.Cells["PatientMobile"].Value.ToString();
                    this.txt_patientname.Text = row.Cells["PatientName"].Value.ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error in datagrid event" + ex.ToString());
                }
            }
        }

    }
}
