using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingDetection
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1_val.Text = "Dashboard";
            guna2PictureBox3_val.Image = Properties.Resources.icons8_dashboard_48px;
            container(new Overview());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label1_val.Text = "Dashboard";
            guna2PictureBox3_val.Image = Properties.Resources.icons8_dashboard_48px;
            container(new Overview());
        }

        private void container(object _form)
        {
            if(guna2Panel3Container.Controls.Count > 0)
            {
                guna2Panel3Container.Controls.Clear();
            }
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel3Container.Controls.Add(fm);
            guna2Panel3Container.Tag = fm;
            fm.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label1_val.Text = "Detection";
            guna2PictureBox3_val.Image = Properties.Resources.icons8_dashboard_48px;
            container(Detection.Instance);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label1_val.Text = "Settings";
            guna2PictureBox3_val.Image = Properties.Resources.icons8_dashboard_48px;
            container(new Settings());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label1_val.Text = "Contact";
            guna2PictureBox3_val.Image = Properties.Resources.icons8_dashboard_48px;
            container(new Contact());

        }
    }
}
