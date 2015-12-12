using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.CPlusPlus;

namespace Object_Robo_Tracker
{
	public partial class RoboTrack : Form
	{

		private Thread _cameraThread1;
		private Thread _cameraThread2;
		private Thread _labelUpdateThread;

		private CameraCapure captureMe = new CameraCapure();
		private RobotServer myRobotServer = new RobotServer();

		private int initCam1 = -1;
		private int initCam2 = -1;
		private bool initCamChangeBool = false;

		public RoboTrack()
		{
			InitializeComponent();
			initCAMLabelsNumbers();
		}

		private void CaptureCamera()
		{
			_cameraThread1 = new Thread(new ThreadStart(CaptureCameraCallback1));
			_cameraThread1.Start();
			_cameraThread2 = new Thread(new ThreadStart(CaptureCameraCallback2));
			_cameraThread2.Start();

		}

		private void LabelUpdater()
		{
			_labelUpdateThread = new Thread(new ThreadStart(UpdateAllTheLabels));
			_labelUpdateThread.Start();
		}

		private void CaptureCameraCallback1()
		{
			// Start Capture From Camera
			captureMe.Capture(initCam1, pictureBox1, pictureBox2, pictureBox3);
		}

		private void CaptureCameraCallback2()
		{
			// Start Capture From Camera
			captureMe.Capture(initCam2, pictureBox4, pictureBox5, pictureBox6);
		}

		#region labels and print stuff
		public void UpdateAllTheLabels()
		{


			while (GlobalVars.abort == false)
			{
                Thread.Sleep(100);

                if (this.cam1LabX.InvokeRequired)
				{
					this.cam1LabX.BeginInvoke((MethodInvoker)delegate () { this.cam1LabX.Text = GlobalVars.theObject1[0].ToString(); ; });
				}
				else
				{
					this.cam1LabX.Text = GlobalVars.theObject1[0].ToString(); ;
				}

				if (this.cam1LabY.InvokeRequired)
				{
					this.cam1LabY.BeginInvoke((MethodInvoker)delegate () { this.cam1LabY.Text = GlobalVars.theObject1[1].ToString(); ; });
				}
				else
				{
					this.cam1LabY.Text = GlobalVars.theObject1[1].ToString(); ;
				}


				if (this.cam2LabX.InvokeRequired)
				{
					this.cam2LabX.BeginInvoke((MethodInvoker)delegate () { this.cam2LabX.Text = GlobalVars.theObject2[0].ToString(); ; });
				}
				else
				{
					this.cam2LabX.Text = GlobalVars.theObject2[0].ToString(); ;
				}

				if (this.cam2LabY.InvokeRequired)
				{
					this.cam2LabY.BeginInvoke((MethodInvoker)delegate () { this.cam2LabY.Text = GlobalVars.theObject2[1].ToString(); ; });
				}
				else
				{
					this.cam2LabY.Text = GlobalVars.theObject2[1].ToString(); ;
				}
			}
		}


		public void visibleAllStuff(bool a)
		{
			Label[] labels = {
				camMarkLab1, camMarkLab2, camMarkLab3, camMarkLab4, camMarkLab5, camMarkLab6
			};
			PictureBox[] boxes = {
				pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6
			};
			foreach (Label label in labels)
			{
				label.Visible = a;
				label.Text = "";
			}
			foreach (PictureBox box in boxes)
			{
				box.Visible = a;
			}

			this.normal_lab.Visible = a;
			this.threshold_lab.Visible = a;
			this.filtered_lab.Visible = a;
			this.cam1_lab.Visible = a;
			this.cam1LabX.Visible = a;
			this.cam1LabY.Visible = a;
			this.cam2_lab.Visible = a;
			this.cam2LabX.Visible = a;
			this.cam2LabY.Visible = a;
			this.trackBarLabel1.Visible = a;
			this.trackBarLabel2.Visible = a;
			this.trackBarLabel3.Visible = a;
			this.trackBar1.Visible = a;
			this.trackBar2.Visible = a;
			this.trackBar3.Visible = a;
			this.robotInfoLab1.Visible = a;
			this.comPortDropDownList.Visible = a;
			this.comPortDropDownList.Enabled = a;
			this.comPortInfoLab1.Visible = a;
			this.returnNestLab1.Visible = a;
			this.returnNestBtn1.Visible = a;
			this.returnHomeLab1.Visible = a;
			this.returnHomeBtn.Visible = a;
			this.trackBtn1.BackColor = Color.MistyRose;



		}

		void visibleAllCamLabels(bool a)
		{
			Label[] labels = {
				camMarkLab1, camMarkLab2, camMarkLab3, camMarkLab4, camMarkLab5, camMarkLab6
			};
			foreach (Label label in labels)
			{
				label.Visible = a;
				label.Text = "";
			}
		}

		public void initCAMLabelsNumbers()
		{
			PictureBox[] boxes = {
				pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6
			};

			Label[] labels = {
				camMarkLab1, camMarkLab2, camMarkLab3, camMarkLab4, camMarkLab5, camMarkLab6
			};

			for (int i = 0; i <= 5; i++)
			{
				var pos = this.PointToScreen(labels[i].Location);
				pos = boxes[i].PointToClient(pos);
				labels[i].Parent = boxes[i];
				labels[i].Location = pos;
			}
		}

		public void initCamsPeek()
		{
			PictureBox[] boxes = {
				pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6
			};
			for (int i = 0; i <= 5; i++)
			{
				captureMe.Camera_Peek(i, boxes[i]);
			}
			initCam1 = -1;
			initCam2 = -1;
		}

		public void initComPorts()
		{
			String boxout = "";

			foreach (String s in myRobotServer.checkComPorts(10))
			{
				boxout += s + "\n";
				comPortDropDownList.Items.Add(s);
			}
			AppendTextBox(boxout + comPortDropDownList.SelectedItem);


		}


		#endregion


		#region start button
		private void btnStart_Click(object sender, EventArgs e)
		{
			GlobalVars.abort = false;
			PictureBox[] boxes = {
				pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6
			};


			string btnText = btnStart.Text.ToString();

			switch (btnText)
			{
				case "Start":

					initCamsPeek();
					initComPorts();
					visibleAllStuff(true);
					initCamChangeBool = true;

					if (pictureBox1.BackColor != System.Drawing.Color.Tomato && pictureBox2.BackColor != System.Drawing.Color.Tomato)
					{
						btnStart.Text = "Start CAMS";

					}
					else
					{
						AppendTextBox("pla Connect all  CAMs \n");
					}
					break;

				case "Start CAMS":
					if (initCam1 != -1 && initCam2 != -1)
					{
						initCamChangeBool = false;
						visibleAllCamLabels(false);

						CaptureCamera();

						LabelUpdater();

						_labelUpdateThread.Priority = ThreadPriority.Lowest;

						btnStart.Text = "Start Robot";

						AppendTextBox("CAMS Started");
					}
					else
					{
						AppendTextBox("Can not start Tracking\nPls select 2 cams");
					}
					break;
				case "Start Robot":

					if (comPortDropDownList.SelectedItem != null)
					{
						this.trackBtn1.Visible = true;
						this.comPortDropDownList.Enabled = false;
						btnStart.Text = "Stop";
						AppendTextBox("Robot Started");
					}
					else
					{
						AppendTextBox("Can not start Robot\nPls select COM port");
					}
					break;
				case "Stop":
					GlobalVars.abort = true;
					visibleAllStuff(false);
					this.trackBtn1.Visible = false;
					AppendTextBox("Program Stopped");


					foreach (PictureBox box in boxes)
					{
						box.BackColor = SystemColors.Control;
					}

					_cameraThread1.Join();
					_cameraThread2.Join();
					_labelUpdateThread.Join();
					btnStart.Text = "Start";
					break;
			}
		}

		#endregion

		#region trackbars;
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			GlobalVars.SENSITIVITY_VALUE = trackBar1.Value;
			GlobalVars.updateScalar();
		}

		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			GlobalVars.BLUR_SIZE = trackBar2.Value;
			GlobalVars.updateScalar();
		}

		private void trackBar3_Scroll(object sender, EventArgs e)
		{
			GlobalVars.MIN_OBJECT_SIZE = trackBar3.Value;
			GlobalVars.updateScalar();
		}
		#endregion

		#region label Color Funktions
		void camNumberChange(int nr, Label lab)
		{
			if (initCamChangeBool == true)
			{
				if (initCam2 == nr)
				{
					initCam2 = -1;
					lab.Text = "";
				}
				else
				{
					if (initCam1 == nr)
					{
						initCam1 = -1;
						lab.Text = "";
					}
					else
					{
						if (initCam1 == -1)
						{
							initCam1 = nr;
							lab.Text = "CAM1";
						}
						else
						{
							if (initCam2 == -1)
							{
								initCam2 = nr;
								lab.Text = "CAM2";
							}
						}
					}
				}
                if(initCam1 != -1 && initCam2 != -1 && initCam1 > initCam2)
                {
                    GlobalVars.switchedCams = true;
                };
				AppendTextBox("CAM1 = " + initCam1 + "\nCAM2 = " + initCam2 + "\n");
			}
		}


		private void pictureBox1_Click(object sender, EventArgs e)
		{
			camNumberChange(0, camMarkLab1);
		}

		private void camMarkLab1_Click(object sender, EventArgs e)
		{
			camNumberChange(0, camMarkLab1);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			camNumberChange(1, camMarkLab2);
		}

		private void camMarkLab2_Click(object sender, EventArgs e)
		{
			camNumberChange(1, camMarkLab2);
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			camNumberChange(2, camMarkLab3);
		}

		private void camMarkLab3_Click(object sender, EventArgs e)
		{
			camNumberChange(2, camMarkLab3);
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			camNumberChange(3, camMarkLab4);
		}

		private void camMarkLab4_Click(object sender, EventArgs e)
		{
			camNumberChange(3, camMarkLab4);
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			camNumberChange(4, camMarkLab5);
		}

		private void camMarkLab5_Click(object sender, EventArgs e)
		{
			camNumberChange(4, camMarkLab5);
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			camNumberChange(5, camMarkLab6);
		}

		private void camMarkLab6_Click(object sender, EventArgs e)
		{
			camNumberChange(5, camMarkLab6);
		}
		#endregion



		private void trackBtn1_Click(object sender, EventArgs e)
		{
			if (this.trackBtn1.BackColor == Color.MistyRose)
			{
				this.trackBtn1.BackColor = Color.LightGreen;
			}
			else
			{
				this.trackBtn1.BackColor = Color.MistyRose;
			}
		}

		public void AppendTextBox(String value)
		{
			if (InvokeRequired)
			{
				this.BeginInvoke(new Action<string>(AppendTextBox), new object[] { value });
				return;
			}
			richTextBox1.Text = value;
		}

		private void RoboTrack_FormClosed(object sender, FormClosedEventArgs e)
		{
			GlobalVars.abort = true;
			if (_cameraThread1 != null)
			{
				_cameraThread1.Join();
			}
			if (_cameraThread2 != null)
			{
				_cameraThread2.Join();
			}
			if (_labelUpdateThread != null)
			{
				_labelUpdateThread.Join();
			}
		}
	}
}
