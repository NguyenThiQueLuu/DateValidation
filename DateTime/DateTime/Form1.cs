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

        private int DaysInMonth(int Year, int Month)
        {
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                return 31;
            else
            {
                if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                    return 30;
                else if (Month == 2)
                {
                    if (Year % 400 == 0)
                        return 29;
                    else if (Year % 100 == 0)
                        return 28;
                    else if (Year % 4 == 0)
                        return 29;
                    else return 28;
                }
                else
                {
                    return 0;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int Day = 0;
            int Month = 0;
            int Year = 0;
            bool flag = true;

            #region Ktra ngày
            string strDay = txtDay.Text;
            try
            {
                Day = int.Parse(strDay);
            }
            catch
            {
                MessageBox.Show("Input data for Day is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (flag && (Day < 1 || Day > 31))
            {
                MessageBox.Show("Input data for Day is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            #endregion

            #region Ktra tháng
            if (flag)
            {
                string strMonth = txtMonth.Text;
                try
                {
                    Month = int.Parse(strMonth);
                }
                catch
                {
                    MessageBox.Show("Input data for Month is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
                if (flag && (Month < 1 || Month > 12))
                {
                    MessageBox.Show("Input data for Month is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            #endregion

            #region Ktra năm
            if (flag)
            {
                string strYear = txtYear.Text;
                try
                {
                    Year = int.Parse(strYear);
                }
                catch
                {
                    MessageBox.Show("Input data for Year is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
                if (flag && (Year < 1000 || Year > 3000))
                {
                    MessageBox.Show("Input data for Year is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            #endregion

            #region Ktra ngày có hợp lệ
            if (flag)
            {
                if (Day <= DaysInMonth(Year, Month))
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
