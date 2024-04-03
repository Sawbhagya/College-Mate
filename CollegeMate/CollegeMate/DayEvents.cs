using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeMate
{
    public partial class DayEvents : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\CollageMate.mdf;Integrated Security=True;");
        
        public DayEvents()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblday_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (LoginPage.userAdmin == "Admin")
            {
                btnNewEvent.Visible = true;

            }
            else {
                btnNewEvent.Visible = false;
            }
            
            display();

            
        }

        private void lblMonth_Click(object sender, EventArgs e)
        {

        }

        private void lblEvent1_Click(object sender, EventArgs e)
        {

        }

        public void display()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(id) FROM new_event where date='" + UserControlDays.static_Day + "/" + Form1.static_Month + "/" + Form1.static_Year + "'", con);
            con.Open();
            int result = (Int32)cmd.ExecuteScalar();
            for (int i = 0; i <result;i++) {
                DayEvent eve = new DayEvent();
                dayEventContainer.Controls.Add(eve);
            }
            cmd.Dispose();
            con.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewEvent eve = new CollegeMate.NewEvent();
            eve.Show();
            this.Hide();
        }

        private void lblDayEvent_Click(object sender, EventArgs e)
        {

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
