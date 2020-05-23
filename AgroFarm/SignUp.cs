using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace AgroFarm
{
    public partial class SignUp : Form
    {
        public static string con = "SERVER=127.0.0.1;UID = root; PASSWORD=; DATABASE= farm";
        MySqlConnection m = new MySqlConnection(con);
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, System.EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void Button7_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Length==0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0 || textBox6.Text.Length == 0 || textBox7.Text.Length == 0 || textBox8.Text.Length == 0)
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                if (textBox1.Text.Equals(textBox2.Text))
                {
                    try
                    {
                        m.Close();
                        m.Open();
                        MySqlCommand cmd = new MySqlCommand("insert into user(Uname,Uid,Address,Email,Phone,Position,Password) values ('" + textBox8.Text + "', '" + textBox7.Text + "', '" + textBox6.Text + "', '" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')", m);
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Added Successfully");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            textBox8.Clear();
                        }
                    }

                    catch
                    {

                    }
                }
            }
        }

        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Login l1 = new Login();
            this.Hide();
            l1.Show();
        }

        private void Button8_Click(object sender, System.EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

        }
    }
}
