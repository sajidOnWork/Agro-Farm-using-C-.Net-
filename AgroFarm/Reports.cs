using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroFarm
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            WarehouseStatusReport w1 = new WarehouseStatusReport();
            this.Hide();
            w1.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            FoodReport f1 = new FoodReport();
            this.Hide();
            f1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Hide();
            h1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Profile p1 = new Profile();
            this.Hide();
            p1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Login.pos.Equals("Owner"))
            {
                this.Hide();
                Reports_Owner r1 = new Reports_Owner();
                r1.Show();
            }
            else
            {
                Reports r1 = new Reports();
                this.Hide();
                r1.Show();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ChangePassword c1 = new ChangePassword();
            this.Hide();
            c1.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            this.Hide();
            l1.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SeedReport s1 = new SeedReport();
            this.Hide();
            s1.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            FertilierReport fr1 = new FertilierReport();
            this.Hide();
            fr1.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            PesticideReport p1 = new PesticideReport();
            this.Hide();
            p1.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            TreatmentInformationReport t1 = new TreatmentInformationReport();
            this.Hide();
            t1.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            TransactionReport t1 = new TransactionReport();
            this.Hide();
            t1.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            EmployeeInformation e1 = new EmployeeInformation ();
            this.Hide();
            e1.Show();
        }
    }
}
