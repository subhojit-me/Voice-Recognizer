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
    public partial class AdminForm : Form
    {

        public static string NameofAdmin;
    public AdminForm()
        {
            InitializeComponent();
            this.timer1.Start();
            this.setlabel();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbl_time.Text = datetime.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete Patient Mistaken event
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Logout button action performed
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedicineForm mf = new MedicineForm();
            this.Hide();
            mf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Patient button event
            AddPatient ap = new AddPatient();
            this.Hide();
            ap.ShowDialog();
        }

        private void setlabel()
        {
            //MessageBox.Show("setLabel called name= " + AdminForm.NameofAdmin);
            this.lbl_wellcome.Text = "Wellcome "+ AdminForm.NameofAdmin;
        }

        private void btn_StaffList_Click(object sender, EventArgs e)
        {
            StaffDetails sd = new StaffDetails();
            this.Hide();
            sd.ShowDialog();
        }

        private void btn_DoctorList_Click(object sender, EventArgs e)
        {
            DoctorDetailsfromAdmin da = new DoctorDetailsfromAdmin();
            this.Hide();
            da.ShowDialog();
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            AddPatient ap = new AddPatient();
            this.Hide();
            ap.ShowDialog();
        }

        private void btn_DeletePatient_Click(object sender, EventArgs e)
        {
            DeletePatient dp = new DeletePatient();
            this.Hide();
            dp.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LaboratoryForm lf = new LaboratoryForm();
            this.Hide();
            lf.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Admin Manage Button event
            AdminManageForm amf = new AdminManageForm();
            this.Hide();
            amf.ShowDialog();
        }

        private void btn_Billings_Click(object sender, EventArgs e)
        {
            Biling bl = new Biling();
            this.Hide();
            bl.ShowDialog();
        }

        private void lbl_wellcome_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
