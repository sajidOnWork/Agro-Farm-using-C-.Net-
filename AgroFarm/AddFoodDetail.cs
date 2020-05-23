using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AgroFarm
{
    public partial class AddFoodDetail : Form
    {
        
        SqlConnection m = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=farm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public AddFoodDetail()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

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
            
                    try
                    {
                        m.Close();
                        m.Open();
                        
                        SqlDataAdapter cm = new SqlDataAdapter("select * from [dbo].[food]", m);
                        DataTable dt = new DataTable();
                        cm.Fill(dt);
                        int j=0;
                        foreach (DataRow item in dt.Rows)
                        {
                            if (item[1].ToString().Equals(textBox2.Text))
                            {
                                if (item[4].ToString().Equals(textBox5.Text))
                                {
                                    int x = Int32.Parse(item[2].ToString())+Int32.Parse(textBox4.Text);
                                    SqlCommand cm1 = new SqlCommand("update [dbo].[food] set Quantity = '"+x+"' WHERE Fname= '"+textBox2.Text+"'", m);
                                    int b = cm1.ExecuteNonQuery();

                                    int k = Int32.Parse(textBox4.Text) * Int32.Parse(textBox5.Text);
                                    SqlCommand cmd2 = new SqlCommand("insert into [dbo].[transaction](TRname,TRType,Price,Description,Date) values ('" + textBox2.Text + " production', 'debit', '" + k + "', 'Production Expense', '" + DateTime.Now.ToString() + "')", m);
                                    int c = cmd2.ExecuteNonQuery();

                                    SqlCommand cmd3 = new SqlCommand("update [dbo].[warehouse] set Quantity = Quantity+'" + textBox4.Text + "' WHERE FoodName= '" + textBox2.Text + "'", m);
                                    int d = cmd3.ExecuteNonQuery();

                                    j = 1;
                                    if (b > 0)
                                    {
                                        MessageBox.Show("Updated Successfully");
                                        
                                        textBox2.Clear();
                                        textBox3.Clear();
                                        textBox4.Clear();
                                        textBox5.Clear();
                                        textBox6.Clear();
                                    }
                            
                                }
                              
                            }
                            
                        }

                        if (j == 0)
                        {
                            SqlCommand cmd = new SqlCommand("insert into [dbo].[food](Fname,Type,Quantity,PRate,SRate) values ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", m);
                            int a = cmd.ExecuteNonQuery();

                            int x = Int32.Parse(textBox4.Text) * Int32.Parse(textBox5.Text);
                            SqlCommand cmd2 = new SqlCommand("insert into [dbo].[transaction](TRname,TRType,Price,Description,Date) values ('" + textBox2.Text + " production', 'debit', '" + x + "', 'Production Expense', '" + DateTime.Now.ToString() + "')", m);
                            int b = cmd2.ExecuteNonQuery();

                            SqlCommand cmd3 = new SqlCommand("update [dbo].[warehouse] set Quantity = Quantity+'"+textBox4.Text+"' WHERE FoodName= '" + textBox2.Text + "'", m);
                            int c = cmd3.ExecuteNonQuery();

                            if (a > 0)
                            {
                                MessageBox.Show("Added Successfully");
                                
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                            }
                            m.Close();
                        }
                    }

                    catch
                    {
                        MessageBox.Show("Error!!");
                    }
                
            
        }

        private void AddFoodDetail_Load(object sender, EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
