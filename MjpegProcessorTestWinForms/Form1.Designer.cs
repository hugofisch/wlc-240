namespace MjpegProcessorTestWinForms
{
	partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.bntLeftFwd = new System.Windows.Forms.Button();
            this.bntLeftBck = new System.Windows.Forms.Button();
            this.bntLeftStp = new System.Windows.Forms.Button();
            this.bntRightStp = new System.Windows.Forms.Button();
            this.bntRightBck = new System.Windows.Forms.Button();
            this.bntRightFwd = new System.Windows.Forms.Button();
            this.bntCamStp = new System.Windows.Forms.Button();
            this.bntCamDwn = new System.Windows.Forms.Button();
            this.bntCamUp = new System.Windows.Forms.Button();
            this.bntFwd = new System.Windows.Forms.Button();
            this.bntBack = new System.Windows.Forms.Button();
            this.bntLeft = new System.Windows.Forms.Button();
            this.bntRight = new System.Windows.Forms.Button();
            this.bntStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(0, 599);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Video Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Margin = new System.Windows.Forms.Padding(4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(853, 591);
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // bntLeftFwd
            // 
            this.bntLeftFwd.Location = new System.Drawing.Point(173, 599);
            this.bntLeftFwd.Name = "bntLeftFwd";
            this.bntLeftFwd.Size = new System.Drawing.Size(81, 28);
            this.bntLeftFwd.TabIndex = 2;
            this.bntLeftFwd.Text = "Left Fwd";
            this.bntLeftFwd.UseVisualStyleBackColor = true;
            this.bntLeftFwd.Click += new System.EventHandler(this.bntLeftFwd_Click_1);
            // 
            // bntLeftBck
            // 
            this.bntLeftBck.Location = new System.Drawing.Point(173, 633);
            this.bntLeftBck.Name = "bntLeftBck";
            this.bntLeftBck.Size = new System.Drawing.Size(81, 28);
            this.bntLeftBck.TabIndex = 3;
            this.bntLeftBck.Text = "Left Bck";
            this.bntLeftBck.UseVisualStyleBackColor = true;
            this.bntLeftBck.Click += new System.EventHandler(this.bntLeftBck_Click);
            // 
            // bntLeftStp
            // 
            this.bntLeftStp.Location = new System.Drawing.Point(173, 667);
            this.bntLeftStp.Name = "bntLeftStp";
            this.bntLeftStp.Size = new System.Drawing.Size(81, 28);
            this.bntLeftStp.TabIndex = 4;
            this.bntLeftStp.Text = "Left Stop";
            this.bntLeftStp.UseVisualStyleBackColor = true;
            this.bntLeftStp.Click += new System.EventHandler(this.bntLeftStp_Click);
            // 
            // bntRightStp
            // 
            this.bntRightStp.Location = new System.Drawing.Point(272, 667);
            this.bntRightStp.Name = "bntRightStp";
            this.bntRightStp.Size = new System.Drawing.Size(81, 28);
            this.bntRightStp.TabIndex = 7;
            this.bntRightStp.Text = "Right Stp";
            this.bntRightStp.UseVisualStyleBackColor = true;
            this.bntRightStp.Click += new System.EventHandler(this.bntRightStp_Click);
            // 
            // bntRightBck
            // 
            this.bntRightBck.Location = new System.Drawing.Point(272, 633);
            this.bntRightBck.Name = "bntRightBck";
            this.bntRightBck.Size = new System.Drawing.Size(81, 28);
            this.bntRightBck.TabIndex = 6;
            this.bntRightBck.Text = "Right Bck";
            this.bntRightBck.UseVisualStyleBackColor = true;
            this.bntRightBck.Click += new System.EventHandler(this.bntRightBck_Click);
            // 
            // bntRightFwd
            // 
            this.bntRightFwd.Location = new System.Drawing.Point(272, 599);
            this.bntRightFwd.Name = "bntRightFwd";
            this.bntRightFwd.Size = new System.Drawing.Size(81, 28);
            this.bntRightFwd.TabIndex = 5;
            this.bntRightFwd.Text = "Right Fwd";
            this.bntRightFwd.UseVisualStyleBackColor = true;
            this.bntRightFwd.Click += new System.EventHandler(this.bntRightFwd_Click);
            // 
            // bntCamStp
            // 
            this.bntCamStp.Location = new System.Drawing.Point(369, 667);
            this.bntCamStp.Name = "bntCamStp";
            this.bntCamStp.Size = new System.Drawing.Size(81, 28);
            this.bntCamStp.TabIndex = 10;
            this.bntCamStp.Text = "Cam Stop";
            this.bntCamStp.UseVisualStyleBackColor = true;
            this.bntCamStp.Click += new System.EventHandler(this.bntCamStp_Click);
            // 
            // bntCamDwn
            // 
            this.bntCamDwn.Location = new System.Drawing.Point(369, 633);
            this.bntCamDwn.Name = "bntCamDwn";
            this.bntCamDwn.Size = new System.Drawing.Size(81, 28);
            this.bntCamDwn.TabIndex = 9;
            this.bntCamDwn.Text = "Cam Dwn";
            this.bntCamDwn.UseVisualStyleBackColor = true;
            this.bntCamDwn.Click += new System.EventHandler(this.bntCamDwn_Click);
            // 
            // bntCamUp
            // 
            this.bntCamUp.Location = new System.Drawing.Point(369, 599);
            this.bntCamUp.Name = "bntCamUp";
            this.bntCamUp.Size = new System.Drawing.Size(81, 28);
            this.bntCamUp.TabIndex = 8;
            this.bntCamUp.Text = "Cam Up";
            this.bntCamUp.UseVisualStyleBackColor = true;
            this.bntCamUp.Click += new System.EventHandler(this.bntCamUp_Click);
            // 
            // bntFwd
            // 
            this.bntFwd.Location = new System.Drawing.Point(606, 599);
            this.bntFwd.Name = "bntFwd";
            this.bntFwd.Size = new System.Drawing.Size(81, 28);
            this.bntFwd.TabIndex = 11;
            this.bntFwd.Text = "For&ward";
            this.bntFwd.UseVisualStyleBackColor = true;
            this.bntFwd.Click += new System.EventHandler(this.bntFwd_Click);
            // 
            // bntBack
            // 
            this.bntBack.Location = new System.Drawing.Point(606, 667);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(81, 28);
            this.bntBack.TabIndex = 12;
            this.bntBack.Text = "Back&s";
            this.bntBack.UseVisualStyleBackColor = true;
            this.bntBack.Click += new System.EventHandler(this.bntBack_Click);
            // 
            // bntLeft
            // 
            this.bntLeft.Location = new System.Drawing.Point(544, 633);
            this.bntLeft.Name = "bntLeft";
            this.bntLeft.Size = new System.Drawing.Size(81, 28);
            this.bntLeft.TabIndex = 13;
            this.bntLeft.Text = "Left&a";
            this.bntLeft.UseVisualStyleBackColor = true;
            this.bntLeft.Click += new System.EventHandler(this.bntLeft_Click);
            // 
            // bntRight
            // 
            this.bntRight.Location = new System.Drawing.Point(672, 633);
            this.bntRight.Name = "bntRight";
            this.bntRight.Size = new System.Drawing.Size(81, 28);
            this.bntRight.TabIndex = 14;
            this.bntRight.Text = "Right&d";
            this.bntRight.UseVisualStyleBackColor = true;
            this.bntRight.Click += new System.EventHandler(this.bntRight_Click);
            // 
            // bntStop
            // 
            this.bntStop.Location = new System.Drawing.Point(772, 599);
            this.bntStop.Name = "bntStop";
            this.bntStop.Size = new System.Drawing.Size(81, 28);
            this.bntStop.TabIndex = 15;
            this.bntStop.Text = "Stop&q";
            this.bntStop.UseVisualStyleBackColor = true;
            this.bntStop.Click += new System.EventHandler(this.bntStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 702);
            this.Controls.Add(this.bntStop);
            this.Controls.Add(this.bntRight);
            this.Controls.Add(this.bntLeft);
            this.Controls.Add(this.bntBack);
            this.Controls.Add(this.bntFwd);
            this.Controls.Add(this.bntCamStp);
            this.Controls.Add(this.bntCamDwn);
            this.Controls.Add(this.bntCamUp);
            this.Controls.Add(this.bntRightStp);
            this.Controls.Add(this.bntRightBck);
            this.Controls.Add(this.bntRightFwd);
            this.Controls.Add(this.bntLeftStp);
            this.Controls.Add(this.bntLeftBck);
            this.Controls.Add(this.bntLeftFwd);
            this.Controls.Add(this.image);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "WLC-240 Controller";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button bntLeftFwd;
        private System.Windows.Forms.Button bntLeftBck;
        private System.Windows.Forms.Button bntLeftStp;
        private System.Windows.Forms.Button bntRightStp;
        private System.Windows.Forms.Button bntRightBck;
        private System.Windows.Forms.Button bntRightFwd;
        private System.Windows.Forms.Button bntCamStp;
        private System.Windows.Forms.Button bntCamDwn;
        private System.Windows.Forms.Button bntCamUp;
        private System.Windows.Forms.Button bntFwd;
        private System.Windows.Forms.Button bntBack;
        private System.Windows.Forms.Button bntLeft;
        private System.Windows.Forms.Button bntRight;
        private System.Windows.Forms.Button bntStop;
	}
}

