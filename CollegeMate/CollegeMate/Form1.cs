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

namespace CollegeMate
{
    public partial class Form1 : Form
    {
        public int month, year;

        public static int static_Month, static_Year;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            displayDays();
        }

        private void displayDays() {

            DateTime now = DateTime.Now;


            month = now.Month;
            year = now.Year;

            static_Month = month;
            static_Year = year;

            String nameMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = nameMonth + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++) {
                BlankUserControl ucblank = new BlankUserControl();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++) {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage newLogin = new LoginPage();
            newLogin.Show();
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month--;

            static_Month = month;
            static_Year = year;

            String nameMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = nameMonth + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                BlankUserControl ucblank = new BlankUserControl();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month++;

            static_Month = month;
            static_Year = year;

            String nameMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = nameMonth + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                BlankUserControl ucblank = new BlankUserControl();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }
    }
}
