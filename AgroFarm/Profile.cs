using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AgroFarm
{
    public partial class Profile : Form
    {
        
        SqlConnection m = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=farm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Profile()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                m.Close();
                m.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from [dbo].[user]  where Uname='"+Login.name+"'", m);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int a = dataGridView1.Rows.Add();
                    dataGridView1.Rows[a].Cells[0].Value = item[0];
                    dataGridView1.Rows[a].Cells[1].Value = item[1];
                    dataGridView1.Rows[a].Cells[2].Value = item[2];
                    dataGridView1.Rows[a].Cells[3].Value = item[3];
                    dataGridView1.Rows[a].Cells[4].Value = item[4];
                    dataGridView1.Rows[a].Cells[5].Value = item[6];
                }
                m.Close();
            }

            catch
            {
                
            }
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
    }
}
