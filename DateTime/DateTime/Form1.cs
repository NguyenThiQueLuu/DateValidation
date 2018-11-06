using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace DateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDay.Text = " ";
            txtMonth.Text = " ";
            txtYear.Text = " ";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int Day = 0;
            int Month = 0;
            int Year = 0;
            bool flag = true;

            #region Ktra ngày
            string strDay = txtDay.Text;
            Day = Helper.CheckDays(strDay);
            if (Day == -1)
            {
                MessageBox.Show("Input data for Day is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (flag && Day == -2)
            {
                MessageBox.Show("Input data for Day is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            #endregion

            #region Ktra tháng
            string strMonth = txtMonth.Text;
            Month = Helper.CheckMonth(strMonth);
            if (flag)
            {
                if (Month == -1)
                {
                    MessageBox.Show("Input data for Month is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
                if (flag && Month == -2)
                {
                    MessageBox.Show("Input data for Month is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            #endregion

            #region Ktra năm
            string strYear = txtYear.Text;
            Year = Helper.CheckYear(strYear);
            if (flag)
            {
                if(Year == -1)
                {
                    MessageBox.Show("Input data for Year is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
                if (flag && Year == -2)
                {
                    MessageBox.Show("Input data for Year is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            #endregion

            #region Ktra ngày có hợp lệ
            if (flag)
            {
                if (Day <= Helper.DaysInMonth(Year, Month))
                {
                    MessageBox.Show(string.Format("{0}/{1}/{2} is correct date time!", Day.ToString("00"), Month.ToString("00"), Year.ToString("0000")), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("{0}/{1}/{2} is NOT correct date time!", Day.ToString("00"), Month.ToString("00"), Year.ToString("0000")), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            #endregion
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure to exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.No)
            {
                e.Cancel = true;
            }
           
        }
    }
}
