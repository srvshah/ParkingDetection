namespace ParkingDetection
{
    partial class Detection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFrame = new Guna.UI2.WinForms.Guna2Button();
            this.btnVideo = new Guna.UI2.WinForms.Guna2Button();
            this.btnRun = new Guna.UI2.WinForms.Guna2Button();
            this.labelFrame = new Guna.UI.WinForms.GunaLabel();
            this.labelVideo = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnFrame
            // 
            this.btnFrame.AutoRoundedCorners = true;
            this.btnFrame.BorderRadius = 12;
            this.btnFrame.CheckedState.Parent = this.btnFrame;
            this.btnFrame.CustomImages.Parent = this.btnFrame;
            this.btnFrame.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btnFrame.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFrame.ForeColor = System.Drawing.Color.White;
            this.btnFrame.HoverState.Parent = this.btnFrame;
            this.btnFrame.Location = new System.Drawing.Point(38, 53);
            this.btnFrame.Name = "btnFrame";
            this.btnFrame.ShadowDecoration.Parent = this.btnFrame;
            this.btnFrame.Size = new System.Drawing.Size(122, 26);
            this.btnFrame.TabIndex = 0;
            this.btnFrame.Text = "Select Frame Image";
            this.btnFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.AutoRoundedCorners = true;
            this.btnVideo.BorderRadius = 12;
            this.btnVideo.CheckedState.Parent = this.btnVideo;
            this.btnVideo.CustomImages.Parent = this.btnVideo;
            this.btnVideo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btnVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVideo.ForeColor = System.Drawing.Color.White;
            this.btnVideo.HoverState.Parent = this.btnVideo;
            this.btnVideo.Location = new System.Drawing.Point(38, 175);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.ShadowDecoration.Parent = this.btnVideo;
            this.btnVideo.Size = new System.Drawing.Size(110, 26);
            this.btnVideo.TabIndex = 1;
            this.btnVideo.Text = "Select Video";
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnRun
            // 
            this.btnRun.AutoRoundedCorners = true;
            this.btnRun.BorderRadius = 12;
            this.btnRun.CheckedState.Parent = this.btnRun;
            this.btnRun.CustomImages.Parent = this.btnRun;
            this.btnRun.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.HoverState.Parent = this.btnRun;
            this.btnRun.Location = new System.Drawing.Point(38, 306);
            this.btnRun.Name = "btnRun";
            this.btnRun.ShadowDecoration.Parent = this.btnRun;
            this.btnRun.Size = new System.Drawing.Size(110, 26);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // labelFrame
            // 
            this.labelFrame.AutoSize = true;
            this.labelFrame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrame.Location = new System.Drawing.Point(35, 32);
            this.labelFrame.Name = "labelFrame";
            this.labelFrame.Size = new System.Drawing.Size(23, 17);
            this.labelFrame.TabIndex = 3;
            this.labelFrame.Text = "---";
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelVideo.Location = new System.Drawing.Point(35, 154);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(23, 17);
            this.labelVideo.TabIndex = 4;
            this.labelVideo.Text = "---";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(167, 306);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(110, 26);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Clear";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Detection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 363);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.labelVideo);
            this.Controls.Add(this.labelFrame);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detection";
            this.Text = "Detection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnFrame;
        private Guna.UI2.WinForms.Guna2Button btnVideo;
        private Guna.UI2.WinForms.Guna2Button btnRun;
        private Guna.UI.WinForms.GunaLabel labelFrame;
        private Guna.UI.WinForms.GunaLabel labelVideo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}