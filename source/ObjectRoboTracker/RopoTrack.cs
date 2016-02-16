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
		private Thread _labelUpdateThread;
		private Thread _robotMovementThread;

		private CameraCapure captureMe = new CameraCapure();
		private RobotServer myRobotServer;

		private int initCam1 = -1;
		private bool initCamChangeBool = false;

		public RoboTrack()
		{
			InitializeComponent();
			initCAMLabelsNumbers();
		}

		private void captureCamera()
		{
			_cameraThread1 = new Thread(new ThreadStart(captureCameraRoutine1));
			_cameraThread1.Start();
		}

		private void labelUpdater()
		{
			_labelUpdateThread = new Thread(new ThreadStart(UpdateAllTheLabels));
			_labelUpdateThread.Start();
		}

		private void robotMovementRoutine()
		{
			GlobalVars.robotRoutine = true;
			String selectedComPort = comPortDropDownList.SelectedItem.ToString();
			myRobotServer = new RobotServer(selectedComPort);
			_robotMovementThread = new Thread(new ThreadStart(myRobotServer.movementRoutine));
			_robotMovementThread.Start();


		}

		private void captureCameraRoutine1()
		{
			// Start Capture From Camera
			captureMe.capture(initCam1, pictureBox1, pictureBox2, pictureBox3, pictureBox7);
		}

		//private void captureCameraRoutine2()
		//{
		//	// Start Capture From Camera
		//	captureMe.capture(initCam2, pictureBox4, pictureBox5, pictureBox6, pictureBox8);
		//}

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
				captureMe.cameraPeek(i, boxes[i]);
			}
			initCam1 = -1;
		}

		public void initComPorts()
		{
			String boxout = "";

			foreach (String s in RobotServer.checkComPorts(10))
			{
				boxout += s + "\n";
				comPortDropDownList.Items.Add(s);
			}
			AppendTextBox(boxout + comPortDropDownList.SelectedItem);
		}


		#region labels and print stuff
		public void UpdateAllTheLabels()
		{


			while (GlobalVars.abort == false)
			{
				Thread.Sleep(100);
				

				if (this.cam1LabX.InvokeRequired)
				{
					this.cam1LabX.BeginInvoke((MethodInvoker)delegate () { this.cam1LabX.Text = GlobalVars.theFinalObject1[0].ToString(); ; });
				}
				else
				{
					this.cam1LabX.Text = GlobalVars.theFinalObject1[0].ToString(); ;
				}

				if (this.cam1LabY.InvokeRequired)
				{
					this.cam1LabY.BeginInvoke((MethodInvoker)delegate () { this.cam1LabY.Text = GlobalVars.theFinalObject1[1].ToString(); ; });
				}
				else
				{
					this.cam1LabY.Text = GlobalVars.theFinalObject1[1].ToString(); ;
				}

			}
		}


		public void visibleAllStuff(bool bool_var)
		{
			Label[] labels = {
				camMarkLab1, camMarkLab2, camMarkLab3, camMarkLab4, camMarkLab5, camMarkLab6
			};
			PictureBox[] boxes = {
				pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7
			};
			foreach (Label label in labels)
			{
				label.Visible = bool_var;
				label.Text = "";
			}
			foreach (PictureBox box in boxes)
			{
				box.Visible = bool_var;
			}

			this.normal_lab.Visible = bool_var;
			this.threshold_lab.Visible = bool_var;
			this.filtered_lab.Visible = bool_var;
			this.cam1_lab.Visible = bool_var;
			this.cam1LabX.Visible = bool_var;
			this.cam1LabY.Visible = bool_var;
			this.trackBarLabel1.Visible = bool_var;
			this.trackBarLabel2.Visible = bool_var;
			this.trackBarLabel3.Visible = bool_var;
			this.trackBar1.Visible = bool_var;
			this.trackBar2.Visible = bool_var;
			this.trackBar3.Visible = bool_var;
			this.robotInfoLab1.Visible = bool_var;
			this.comPortDropDownList.Visible = bool_var;
			this.comPortDropDownList.Enabled = bool_var;
			this.comPortInfoLab1.Visible = bool_var;
			this.returnNestLab1.Visible = bool_var;
			this.returnNestBtn1.Visible = bool_var;
			this.returnHomeLab1.Visible = bool_var;
			this.returnHomeBtn.Visible = bool_var;
			this.resetRoboErrBtn.Visible = bool_var;
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



		#endregion


		#region start button casing
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
					AppendTextBox("Program Started");
					initCamsPeek();
					initComPorts();
					visibleAllStuff(true);
					initCamChangeBool = true;

					if (pictureBox1.BackColor != System.Drawing.Color.Tomato)
					{
						btnStart.Text = "Start CAM";

					}
					else
					{
						AppendTextBox("please connect at least one camera\n");
					}
					break;

				case "Start CAM":
					//if (initCam1 != -1 && initCam2 != -1)
					if (initCam1 != -1)
					{
						PictureBox[] box456 = {
							pictureBox4, pictureBox5, pictureBox6
						};
						foreach (PictureBox box in box456)
						{
							box.Visible = false;
						}

						initCamChangeBool = false;
						visibleAllCamLabels(false);


						captureCamera();

						labelUpdater();

						_labelUpdateThread.Priority = ThreadPriority.Lowest;

						btnStart.Text = "Start Robot";

						AppendTextBox("CAM Started");
					}
					else
					{
						AppendTextBox("Can not start tracking\nPlease select one camera");
					}
					break;
				case "Start Robot":

					if (comPortDropDownList.SelectedItem != null && comPortDropDownList.SelectedItem.ToString() != "no one")
					{
						this.trackBtn1.Visible = true;
						this.comPortDropDownList.Enabled = false;

						robotMovementRoutine();

						btnStart.Text = "Stop";
						AppendTextBox("Robot Started");
					}
					else
					{
						AppendTextBox("Can not start robot\nPls select COM port");
					}
					break;
				case "Stop":
					GlobalVars.abort = true;
					GlobalVars.robotRoutine = false;
					GlobalVars.robotCanMove = false;
					visibleAllStuff(false);
					this.trackBtn1.Visible = false;


					AppendTextBox("Program Stopped");
					comPortDropDownList.Items.Clear();


					foreach (PictureBox box in boxes)
					{
						box.BackColor = SystemColors.Control;
					}

					_cameraThread1.Join();
					_labelUpdateThread.Join();
					if (_robotMovementThread != null)
					{
						_robotMovementThread.Join();
					}
					btnStart.Text = "Start";
					break;
			}
		}

		#endregion

		#region trackbars;
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			GlobalVars.sensitivityValue = trackBar1.Value;
			GlobalVars.updateScalar();
		}

		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			GlobalVars.blurSizeSingle = trackBar2.Value;
			GlobalVars.updateScalar();
		}

		private void trackBar3_Scroll(object sender, EventArgs e)
		{
			GlobalVars.minObjectSize = trackBar3.Value;
			GlobalVars.updateScalar();
		}
		#endregion

		#region label Color Funktions
		void camNumberChange(int nr, Label lab)
		{
			if (initCamChangeBool == true)
			{
				//if (initCam2 == nr)
				//{
				//	initCam2 = -1;
				//	lab.Text = "";
				//}
				//else
				//{
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
					//else
					//{
					//	if (initCam2 == -1)
					//	{
					//		initCam2 = nr;
					//		lab.Text = "CAM2";
					//	}
					//}
				}
				//}
				//if (initCam1 != -1 && initCam2 != -1 && initCam1 > initCam2)
				//if (initCam1 != -1)
				//{
				//	GlobalVars.switchedCams = true;
				//};
				//AppendTextBox("CAM1 = " + initCam1 + "\nCAM2 = " + initCam2 + "\n");
				AppendTextBox("Selected camera at port: " + initCam1 + "\n");
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
				GlobalVars.robotCanMove = true;
				AppendTextBox("Robot now will move");
			}
			else
			{
				this.trackBtn1.BackColor = Color.MistyRose;
				GlobalVars.robotCanMove = false;
				AppendTextBox("Robot now will stop");
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
			if (_labelUpdateThread != null)
			{
				_labelUpdateThread.Join();
			}
			if (_robotMovementThread != null)
			{
				_robotMovementThread.Join();
			}
		}

		private void returnHomeBtn_Click(object sender, EventArgs e)
		{
			if (myRobotServer != null)
			{
				myRobotServer.moveHome();
			}
		}

		private void returnNestBtn1_Click(object sender, EventArgs e)
		{
			if (myRobotServer != null)
			{
				myRobotServer.moveNest();
			}
		}

		private void resetRoboErrBtn_Click(object sender, EventArgs e)
		{
			if (myRobotServer != null)
			{
				myRobotServer.resetError();
			}
		}

	}
}
