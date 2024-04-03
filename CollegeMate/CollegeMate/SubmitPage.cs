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
using System.IO;

namespace CollegeMate
{
    public partial class SubmitPage : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\CollageMate.mdf;Integrated Security=True;");
        String imageLocation = "";
        Byte[] ImageByteArray;

        String Type_Event;
        public SubmitPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prevBtn = new Form1();
            prevBtn.Show();
            Close();
        }

        private void SubmitPage_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WereWolf\Documents\CollageMate.mdf;Integrated Security=True;");
            btnOk.Visible = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM new_event where date ='" + UserControlDays.static_Day + "/" + Form1.static_Month + "/" + Form1.static_Year + "'", con);

            //cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", UserControlDays.static_Day + "/" + Form1.static_Month + "/" + Form1.static_Year);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtDesc.Text = reader["Name"].ToString()+"\r\n"+reader["Description"].ToString();
                txtDateAssigned.Text = reader["Date"].ToString();
                txtDateDead.Text = reader["Deadline"].ToString();
            }
            Type_Event = reader["Type_of_Event"].ToString();
            if (Type_Event != "Assignment") {
                btnAddFile.Visible = false;
                btnSubmit.Visible = false;
                btnOk.Visible = true;
                pictureBox.Visible = false;
                lblFile.Visible = false;
            }
            lblSubmission.Text = reader["Type_of_Event"].ToString();
            cmd.Dispose();
            con.Close();

            
           
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            
            
                OpenFileDialog opendlg = new OpenFileDialog();
                opendlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                opendlg.Filter = "All Files (*.*)|*.*";

                if (opendlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    imageLocation = opendlg.FileName;
                    pictureBox.ImageLocation = imageLocation;
                    MessageBox.Show("Image Uploaded", "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            
            
            
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            Image temp = new Bitmap(imageLocation);
            MemoryStream strm = new MemoryStream();
            temp.Save(strm,System.Drawing.Imaging.ImageFormat.Jpeg);
            ImageByteArray = strm.ToArray();

            String sql = "INSERT INTO Submit(Name,Attachment) values(@name,@Attachment)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            con.Open();
            cmd.Parameters.AddWithValue("Name", txtDesc.Text);
            cmd.Parameters.AddWithValue("Attachment", ImageByteArray);
            cmd.Connection = con;
            //cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Successfully Subimtted", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDateAssigned_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
