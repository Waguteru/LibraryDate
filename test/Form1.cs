using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingDateTime;
using LeapYear;
using TimeDifference;
using FindingDay;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkingDateTime.Form1 form = new WorkingDateTime.Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeapYear.Form1 form = new LeapYear.Form1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeDifference.Form1 form = new TimeDifference.Form1();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FindingDay.Form1 form = new FindingDay.Form1();
            form.Show();
        }
    }
}
