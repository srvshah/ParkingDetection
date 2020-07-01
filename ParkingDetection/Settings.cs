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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        

        
        private void Settings_Load(object sender, EventArgs e)
        {
            txtFrameNo.Text = Detection.Instance.startFrame.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if(int.TryParse(txtFrameNo.Text, out int result))
            {
                Detection.Instance.startFrame = result;
                MessageBox.Show("Settings Saved");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Detection.Instance.startFrame = 400;
            txtFrameNo.Text = "400";
            
        }
    }
}
