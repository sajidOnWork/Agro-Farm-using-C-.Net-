using System.Windows.Forms;

namespace AgroFarm
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Home h1 = new Home();
            this.Hide();
            h1.Show();
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            Profile p1 = new Profile();
            this.Hide();
            p1.Show();
        }

        private void Button4_Click(object sender, System.EventArgs e)
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

        private void Button5_Click(object sender, System.EventArgs e)
        {
            ChangePassword c1 = new ChangePassword();
            this.Hide();
            c1.Show();
        }

        private void Button6_Click(object sender, System.EventArgs e)
        {
            Login l1 = new Login();
            this.Hide();
            l1.Show();
        }

        private void Button7_Click(object sender, System.EventArgs e)
        {
            AddNewUser n1 = new AddNewUser();
            this.Hide();
            n1.Show();
        }

        private void Button8_Click(object sender, System.EventArgs e)
        {
            AddFoodDetail f1 = new AddFoodDetail();
            this.Hide();
            f1.Show();
        }

        private void Button9_Click(object sender, System.EventArgs e)
        {
            AddSeedDetails s1 = new AddSeedDetails();
            this.Hide();
            s1.Show();
        }

        private void Button10_Click(object sender, System.EventArgs e)
        {
            AddFertilizerDetails fr1 = new AddFertilizerDetails();
            this.Hide();
            fr1.Show();
        }

        private void Button11_Click(object sender, System.EventArgs e)
        {
            AddPesticideDetails p1 = new AddPesticideDetails();
            this.Hide();
            p1.Show();
        }

        private void Button12_Click(object sender, System.EventArgs e)
        {
            AddTreatmentInfo tr1 = new AddTreatmentInfo();
            this.Hide();
            tr1.Show();
        }

        private void Button14_Click(object sender, System.EventArgs e)
        {
            AddTransaction t1 = new AddTransaction();
            this.Hide();
            t1.Show();
        }

        private void Button13_Click(object sender, System.EventArgs e)
        {
            AddEmployeeInfo e1 = new AddEmployeeInfo();
            this.Hide();
            e1.Show();
        }

        private void Button15_Click(object sender, System.EventArgs e)
        {
            AddWarehouseStatus w1 = new AddWarehouseStatus();
            this.Hide();
            w1.Show();
        }
    }
}
