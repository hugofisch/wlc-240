using System;
using System.Windows.Forms;
using MjpegProcessor;
using System.Net.Sockets;



namespace MjpegProcessorTestWinForms
{
	public partial class Form1 : Form
	{
        private TcpClient client;
        private NetworkStream stream;
        const int cSleeptime=500;
		public Form1()
		{
			InitializeComponent();
            client = new TcpClient("10.10.1.1", 8150);
            stream = client.GetStream();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			MjpegDecoder mjpeg = new MjpegDecoder();
			mjpeg.FrameReady += mjpeg_FrameReady;
			mjpeg.Error += mjpeg_Error;
			mjpeg.ParseStream(new Uri("http://10.10.1.1:8196"));
		}

		private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
		{
			image.Image = e.Bitmap;
		}

		void mjpeg_Error(object sender, ErrorEventArgs e)
		{
			MessageBox.Show(e.Message);
		}

        private void bntLeftFwd_Click_1(object sender, EventArgs e)
        {
            stream.WriteByte(0x31);
            stream.WriteByte(0x31);
        }

        private void bntLeftBck_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x31);
            stream.WriteByte(0x32);
        }

        private void bntLeftStp_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x31);
            stream.WriteByte(0x30);
        }

        private void bntRightFwd_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x32);
            stream.WriteByte(0x31);
        }

        private void bntRightBck_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x32);
            stream.WriteByte(0x32);
        }

        private void bntRightStp_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x32);
            stream.WriteByte(0x30);
        }

        private void bntCamUp_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x33);
            stream.WriteByte(0x31);
        }

        private void bntCamDwn_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x33);
            stream.WriteByte(0x32);
        }

        private void bntCamStp_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x33);
            stream.WriteByte(0x30);
        }

        private void bntFwd_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x31);
            stream.WriteByte(0x31);
            stream.WriteByte(0x32);
            stream.WriteByte(0x31);
            System.Threading.Thread.Sleep(cSleeptime);
            stream.WriteByte(0x31);
            stream.WriteByte(0x30);
            stream.WriteByte(0x32);
            stream.WriteByte(0x30);
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x31);
            stream.WriteByte(0x32);
            stream.WriteByte(0x32);
            stream.WriteByte(0x32);
            System.Threading.Thread.Sleep(cSleeptime);
            stream.WriteByte(0x31);
            stream.WriteByte(0x30);
            stream.WriteByte(0x32);
            stream.WriteByte(0x30);
        }

        private void bntLeft_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x31);
            stream.WriteByte(0x32);
            stream.WriteByte(0x32);
            stream.WriteByte(0x31);
            System.Threading.Thread.Sleep(cSleeptime);
            stream.WriteByte(0x31);
            stream.WriteByte(0x30);
            stream.WriteByte(0x32);
            stream.WriteByte(0x30);
        }

        private void bntRight_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x31);
            stream.WriteByte(0x31);
            stream.WriteByte(0x32);
            stream.WriteByte(0x32);
            System.Threading.Thread.Sleep(cSleeptime);
            stream.WriteByte(0x31);
            stream.WriteByte(0x30);
            stream.WriteByte(0x32);
            stream.WriteByte(0x30);
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            stream.WriteByte(0x31);
            stream.WriteByte(0x30);
            stream.WriteByte(0x32);
            stream.WriteByte(0x30);
        }


	}
}
