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
    public partial class DoctorsForm : Form
    {
        public String docName;  //used to get the doctor name from the Login Page
        public DoctorsForm()
        {
            InitializeComponent();
            //this.setLabelName();
        }

        public void setLabelName(String name)
        {
            this.label1.Text = "Wellcome " + name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_patientStatus_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_medicalDetails_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //log out button event click
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void btn_patientStatus_Click_1(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            this.Hide();
            pf.ShowDialog();
        }

        private void btn_medicalDetails_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        { 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
