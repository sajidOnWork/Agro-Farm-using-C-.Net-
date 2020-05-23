using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AgroFarm
{
    public partial class AddSeedDetails : Form
    {
        
        SqlConnection m = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=farm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public AddSeedDetails()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Home h1 = new Home();
            this.Hide();
            h1.Show();
        }

        private void AddSeedDetails_Load(object sender, System.EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            
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

        private void Button7_Click(object sender, System.EventArgs e)
        {
            try
            {
                m.Close();
                m.Open();

                SqlDataAdapter cm = new SqlDataAdapter("select * from [dbo].[seed]", m);
                DataTable dt = new DataTable();
                cm.Fill(dt);
                int j = 0;
                foreach (DataRow item in dt.Rows)
                {
                    if (item[1].ToString().Equals(textBox3.Text))
                    {
                        if (item[3].ToString().Equals(textBox5.Text))
                        {
                            int y = Int32.Parse(item[4].ToString()) + Int32.Parse(textBox4.Text);
                            SqlCommand cm1 = new SqlCommand("update [dbo].[seed] set Quantity = '" + y + "' WHERE Sname= '" + textBox3.Text + "'", m);
                            int h = cm1.ExecuteNonQuery();

                            int k = Int32.Parse(textBox4.Text) * Int32.Parse(textBox5.Text);
                            SqlCommand cmd3 = new SqlCommand("insert into [dbo].[transaction](TRname,TRType,Price,Description,Date) values ('" + textBox3.Text + " seed', 'debit', '" + k + "', 'Seed Expense', '" + DateTime.Now.ToString() + "')", m);
                            int c = cmd3.ExecuteNonQuery();



                            j = 1;
                            if (h > 0)
                            {
                                MessageBox.Show("Updated Successfully");
                                
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                textBox5.Clear();

                            }

                        }

                    }

                }

                if (j == 0)
                {
                    SqlCommand cmd = new SqlCommand("insert into [dbo].[seed](Type,Sname,Quantity,Rate) values ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')", m);
                    int x = Int32.Parse(textBox4.Text) * Int32.Parse(textBox5.Text);
                    SqlCommand cmd2 = new SqlCommand("insert into [dbo].[transaction](TRname,TRType,Price,Description,Date) values ('" + textBox3.Text + " seed', 'debit', '" + x + "', 'Seed Expense', '" + DateTime.Now.ToString() + "')", m);
                    int b = cmd2.ExecuteNonQuery();

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Added Successfully");
                        
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                    }
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
