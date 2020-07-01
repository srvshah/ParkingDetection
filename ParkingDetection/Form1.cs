using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            MessageBox.Show("For Demo\n=======\nUsername: admin\nPassword: admin");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fields are Empty");
            }
            else if(username == "admin" && password == "admin")
            {
                Form2 form = new Form2();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credential");
            }
            
        }



    }
}
