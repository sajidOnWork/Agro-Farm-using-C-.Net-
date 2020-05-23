using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AgroFarm
{
    public partial class Login : Form
    {
        public static string name = "";
        public static string pass = "";
        public static string pos = "";
        SqlConnection m = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=farm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Login()
        {
            InitializeComponent();
            this.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                m.Close();
                m.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[user] order by Uname COLLATE Latin1_General_CS_AS_KS_WS ASC", m);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int x = 0;
                foreach (DataRow item in dt.Rows)
                {
                    if (item[1].ToString().Equals(textBox1.Text) && item[5].ToString().Equals(textBox2.Text))
                    {
                        name = textBox1.Text;
                        pass = textBox2.Text;
                        pos = "" + item[6] + "";
                        Home h1 = new Home();
                        this.Hide();
                        h1.Show();
                        x = 1;
                    }

                }
                if (x == 0)
                {
                    MessageBox.Show("Wrong Username or Password!!");
                }
                m.Close();
                
            }
            catch
            {
                MessageBox.Show("Error!!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}