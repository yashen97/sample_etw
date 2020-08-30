using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTimer.Start();
            label1.Text ="Welcome "+ Login.SetValueForText1;
            time_present.Text = DateTime.Now.ToString("yyyy MMM dd (dddd) hh:mm:ss tt");
           

        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            time_present.Text = DateTime.Now.ToString("yyyy MMM dd (dddd) hh:mm:ss tt");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer pane = new Customer();
            pane.Show();
        }
    }
}
