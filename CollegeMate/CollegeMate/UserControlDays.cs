using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CollegeMate
{
    public partial class UserControlDays : UserControl
    {
        public static string static_Day;
         
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void days(int numday) {
            lblDays.Text = numday+ "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            timer1.Start();
            static_Day = lblDays.Text;
            var dayEvent = new DayEvents();
            dayEvent.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            static_Day = lblDays.Text;
            var dayEvent = new DayEvents();
            dayEvent.Show();

        }
        public void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\CollageMate.mdf;Integrated Security=True;");

            SqlCommand cmd = new SqlCommand("SELECT * FROM new_event where date ='" + lblDays.Text + "/" + Form1.static_Month + "/" + Form1.static_Year+ "'",con);
            con.Open();
            //cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", lblDays.Text + "/" + Form1.static_Month + "/" + Form1.static_Year );
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                lblEvent.Text = reader["Name"].ToString(); 
            }
            //lblEvent.Text = "New Event";
            cmd.Dispose();
            con.Close();

        }
        private void lblEvent_Click(object sender, EventArgs e)
        {

        }

        private void lblDays_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            display();
        }
    }
}
