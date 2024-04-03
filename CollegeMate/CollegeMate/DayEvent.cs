using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeMate
{
    public partial class DayEvent : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\CollageMate.mdf;Integrated Security=True;");

        public DayEvent()
        {
            InitializeComponent();
        }
        public void display()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM new_event where date ='" + UserControlDays.static_Day + "/" + Form1.static_Month + "/" + Form1.static_Year + "'", con);

            cmd.Parameters.AddWithValue("date", UserControlDays.static_Day + "/" + Form1.static_Month + "/" + Form1.static_Year);
            

            SqlDataReader reader = cmd.ExecuteReader();
            
            
            if (reader.Read())
            {
                lblEvent.Text = reader["Name"].ToString();

            }
            cmd.Dispose();

            con.Close();

        }
        private void lblEvent_Click(object sender, EventArgs e)
        {
            SubmitPage link = new CollegeMate.SubmitPage();
            link.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            display(); 
        }

        private void DayEvent_Load(object sender, EventArgs e)
        {
            if (LoginPage.userAdmin == "Admin")
            {
                btnDelete.Visible = true;
            }
            else {
                btnDelete.Visible = false;
            }
            timer1.Start();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from [new_event] where Name = '" + lblEvent.Text + "'", con);

            cmd.ExecuteNonQuery();
           

            con.Close();
            MessageBox.Show("Event Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
        }
    }
}
