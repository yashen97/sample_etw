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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '•';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public static string SetValueForText1 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;

            if (textBox1.Text.Trim() == "Gihan" && textBox2.Text.Trim() == "123")
            {
                
                MainForm obj = new MainForm();
                this.Hide();
                obj.Show();
               
                
            }
            else
                MessageBox.Show("Invalid Credentials");
        }
    }
}
