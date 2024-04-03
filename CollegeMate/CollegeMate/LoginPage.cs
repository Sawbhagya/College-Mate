using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeMate
{
    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\CollageMate.mdf;Integrated Security=True;");
        public static string userAdmin;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void numericText1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            try
            {
                con.Open();
                string quary = "SELECT Username,Password FROM login WHERE username= '" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(quary, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                    userAdmin = username;
                    var login = new Form1();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    var response = MessageBox.Show("Invalid Entry", "Access Denied", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (response == DialogResult.Retry)
                    {
                        txtPassword.SelectionStart = 0;
                        txtPassword.SelectionLength = Text.Length;
                        txtPassword.Focus();
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                con.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblforgotPasssword_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Contact your Admin","Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
