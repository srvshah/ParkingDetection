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
    public partial class Detection : Form
    {
        public int startFrame { get; set; } = 400;
        private Detection()
        {
            InitializeComponent();
        }
        public static readonly Detection Instance = new Detection();

        private void btnFrame_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg;*.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    labelFrame.Text = of.FileName;
                }
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "Video files (*.mp4)|*.mp4|All files (*.*)|*.*";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    labelVideo.Text = of.FileName;
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(labelFrame.Text.Equals("---") || labelVideo.Text.Equals("---") || String.IsNullOrEmpty(labelFrame.Text) || String.IsNullOrEmpty(labelVideo.Text))
            {
                MessageBox.Show("Please Select the Frame Image and Video");
                return;
            }

            ProcessStartInfo pythonInfo = new ProcessStartInfo();
            Process python;
            pythonInfo.FileName = "cmd.exe";

            pythonInfo.Arguments = $@"/K python main.py --image {labelFrame.Text} --data data/coordinates_1.yml --video {labelVideo.Text} --start-frame {startFrame}";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;

            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            labelFrame.Text = "---";
            labelVideo.Text = "---";
        }
    }
}
