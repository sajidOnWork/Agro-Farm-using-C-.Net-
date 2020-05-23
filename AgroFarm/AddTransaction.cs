using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AgroFarm
{
    public partial class AddTransaction : Form
    {
        
        SqlConnection m = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=farm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public AddTransaction()
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
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.Show();
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

        private void Button8_Click(object sender, System.EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void AddTransaction_Load(object sender, System.EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Button7_Click(object sender, System.EventArgs e)
        {
            try
            {
                m.Close();
                m.Open();
                double y = 0.0;
                if (textBox3.Text.Equals("credit"))
                {
                    SqlDataAdapter cm = new SqlDataAdapter("select * from [dbo].[food]", m);
                    DataTable dt = new DataTable();
                    cm.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item[1].ToString().Equals(textBox2.Text))
                        {
                            
                            y = (Int32.Parse(textBox5.Text) + y) / Int32.Parse(item[5].ToString());
                            double x = Int32.Parse(item[2].ToString()) - y;
                            SqlCommand cm6 = new SqlCommand("update food set Quantity = '" + x + "' WHERE Fid= '" + item[0].ToString() + "'", m);
                            int b = cm6.ExecuteNonQuery();
                            break;
                        }
                    }

                    SqlDataAdapter cm1 = new SqlDataAdapter("select * from [dbo].[warehouse]", m);
                    DataTable dt1 = new DataTable();
                    cm1.Fill(dt1);
                    foreach (DataRow item in dt1.Rows)
                    {
                        if (item[2].ToString().Equals(textBox2.Text))
                        {                                                    
                            double x = Int32.Parse(item[3].ToString()) - y;
                            SqlCommand cm2 = new SqlCommand("update [dbo].[warehouse] set Quantity = '" + x + "' WHERE FoodName= '" + textBox2.Text + "'", m);
                            int b = cm2.ExecuteNonQuery();
                            break;
                        }
                    }
                }

                SqlCommand cmd = new SqlCommand("insert into [dbo].[transaction](TRname,TRtype,Description,Price,Date) values ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '"+ DateTime.Now.ToString() +"')", m);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Added Successfully");
                    
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }

                m.Close();
            }

            catch
            {
                MessageBox.Show("Error!!");
            }
        }
    }
}
