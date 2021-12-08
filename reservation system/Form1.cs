using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservation_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] room = new string[] { "二人房 $,1500", "三人房 $2,000", "四人房 $2,500", "總統套房 $20,000" };
            foreach(string r in room)
            { cboRoom.Items.Add(r); }
            int[] num = new int[] { 1, 2, 3, 4 };
            foreach(int n in num)
            { cboNum.Items.Add(n); }
        }
        private void mcaDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStart.Text = mcaDate.SelectionStart.ToShortDateString();
            lblEnd.Text = mcaDate.SelectionEnd.ToShortDateString();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            TimeSpan night = mcaDate.SelectionEnd - mcaDate.SelectionStart;
            int total = 0;
            int num = Convert.ToInt32(cboNum.SelectedItem);
            switch(cboRoom.SelectedIndex)
            {
                case 0:
                    total += 1500 * night.Days * num;
                    break;
                case 1:
                    total += 2000 * night.Days * num;
                    break;
                case 2:
                    total += 2500 * night.Days * num;
                    break;
                case 3:
                    total += 20000 * night.Days * num;
                    break;
            }
            lblShow.Text = "您的訂房資訊如下: \n" + "------------------------\n" +
            "入住日期: " + mcaDate.SelectionStart.ToShortDateString() + "\n" +
            "退房日期: " + mcaDate.SelectionEnd.ToShortDateString() + "\n" +
            "房型/房數: " + cboRoom.SelectedItem.ToString() + "/" + cboNum.SelectedItem.ToString() + " 間\n" +
            "------------------------\n" +
            "金額共計: " + total.ToString("C0");
        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }
        private void lblStart_Click(object sender, EventArgs e)
        {
            
        }

        private void lblEnd_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
