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
    public partial class NewEvent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\CollageMate.mdf;Integrated Security=True;");
        
        public NewEvent()
        {
            InitializeComponent();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            
        }

        private void NewEvent_Load(object sender, EventArgs e)
        {
            txtDate.Text = UserControlDays.static_Day + "/" + Form1.static_Month + "/" + Form1.static_Year;

            cmbEvent.SelectedIndex = 0;
            cmbDeadline.SelectedIndex = 0;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string deadline;
            int deadlineDay = Int32.Parse(UserControlDays.static_Day) + Int32.Parse(cmbDeadline.Text);

            deadline = deadlineDay.ToString() + "/" + Form1.static_Month + "/" + Form1.static_Year;
            con.Open();
            String sql = "INSERT INTO new_event(name,date,Type_of_Event,Description,Deadline)values(@name,@date,@Type_of_event,@Description,@deadline)";
            SqlCommand cmd = con.CreateCommand();
           
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("name", txtName.Text);
            cmd.Parameters.AddWithValue("date", txtDate.Text);
            cmd.Parameters.AddWithValue("Type_of_event", cmbEvent.Text);
            cmd.Parameters.AddWithValue("Description", txtDesc.Text);
            cmd.Parameters.AddWithValue("deadline", deadline);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Event Added", "New Event Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Dispose();
            con.Close();
            
            this.Hide();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
