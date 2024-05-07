using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCountdownTest
{
    public partial class Form1 : Form
    {
        int TimesClicked = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            TimesClicked = TimesClicked - 1;
            outputLabel.Text = TimesClicked.ToString();

            if (TimesClicked < 0)
            {
                Close();
            }
        }
    }
}
