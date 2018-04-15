using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital_Project
{
    public partial class LoginForm : Form
    {
        private String cartagory;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Combox selected= "+this.comboBox.Text);
            //old login button
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radiobtn_Admin_CheckedChanged(object sender, EventArgs e)
        {
            this.cartagory = "Admin";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton_Doctor_CheckedChanged(object sender, EventArgs e)
        {
            this.cartagory = "Doctor";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // new evene of login button
            if (cartagory == "Admin")
            {
                try
                {
                    //MessageBox.Show("Executing Admin Login code");
                    String driver = "datasource=localhost;port=3306;username=root;password=root";
                    MySqlConnection con = new MySqlConnection(driver);
                    MySqlCommand cmd = new MySqlCommand("select * from hospital.admintable where AdminLoginId='" + this.txt_name.Text + "' and AdminPassword='" + this.txt_password.Text + "' ;", con);
                    MySqlDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    int c = 0;

                    while (reader.Read())
                    {
                        c++;
                    }
                    con.Close();

                    if (c == 1)
                    {
                        //successfully authenicated now transfer to corresponding frame
                        AdminForm af = new AdminForm();
                        this.Hide();
                        af.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mismatch in Id and password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in database connection" + ex.ToString());
                }
            }

            else if (cartagory == "Doctor")
            {
                try
                {
                    MessageBox.Show("Executing Doctor code");
                    String driver = "datasource=localhost;port=3306;username=root;password=root";
                    MySqlConnection con = new MySqlConnection(driver);
                    MySqlCommand cmd = new MySqlCommand("select * from hospital.doctortable where DoctorId='" + this.txt_name.Text + "' and Password='" + this.txt_password.Text + "'", con);
                    MySqlDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    int c = 0;
                    while (reader.Read()) c++;
                    con.Close();

                    if (c == 1)
                    {
                        //successfully authenicated now transfer to corresponding frame
                        DoctorsForm df = new DoctorsForm();
                        this.Hide();
                        df.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mismatch in Id and password");
                    }
                }
                catch (Exception eex)
                {
                    MessageBox.Show("Error in database connection" + eex.ToString());
                }
            }

            else
            {
                MessageBox.Show("Choose a cartagory");
            }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}