using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace Object_Robo_Tracker
{
	class RobotServer
	{
		SerialPort myComPort;
		int bodyLeftRight = -6000;
		int bodyUpDown = -1800;


		public RobotServer(string comPort)
		{
			Console.WriteLine(comPort);

			try
			{
				myComPort = new SerialPort(comPort, 9600, Parity.Even, 8, StopBits.One);
				myComPort.RtsEnable = true;
			}
			catch (Exception e)
			{
				Console.WriteLine("init failed");
			}
		}

		public static string[] checkComPorts(int ports)
		{
			String[] comPorts = new String[] { };

			comPorts = SerialPort.GetPortNames();
			return comPorts;
		}


		//
		// This is the main Routine for the Robot
		//
		public void movementRoutine()
		{
			while (GlobalVars.robotRoutine)
			{
				setSpeed(9);
				Thread.Sleep(1000);
				while (GlobalVars.robotCanMove)
				{
					Thread.Sleep(1000);
					GlobalVars.trackingRobot = true;
					moveBody(GlobalVars.theFinalObject1[0], GlobalVars.theFinalObject1[1]);
					Thread.Sleep(1000);
					GlobalVars.trackingRobot = false;

				}
			}
		}

		// Returns Robot to Nest Position
		public void moveNest()
		{
			bodyLeftRight = -6000;
			bodyUpDown = -1800;
			Console.WriteLine("a: " + bodyLeftRight + " b: " + bodyUpDown);

			try
			{
				if (!myComPort.IsOpen)
				{
					myComPort.Open();
				}
				if (myComPort.IsOpen)
				{
					myComPort.Write("NT\n");
					myComPort.Close();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("move Nest error");
			}
		}



		// Initallize the Normal Position
		public void moveHome()
		{
			bodyLeftRight = 0;
			bodyUpDown = 0;
			Console.WriteLine("a: " + bodyLeftRight + " b: " + bodyUpDown);

			try
			{
				if (!myComPort.IsOpen)
				{
					myComPort.Open();
				}
				if (myComPort.IsOpen)
				{
					myComPort.Write("MI-6000,-2200,1800,-900,-3300,0\n");
					myComPort.Close();
				}

			}
			catch (Exception)
			{
				Console.WriteLine("move Home error");
			}
		}

		// Resets the Robot error flag
		public void resetError()
		{
			try
			{
				if (!myComPort.IsOpen)
				{
					myComPort.Open();
				}
				if (myComPort.IsOpen)
				{
					myComPort.Write("RS\n");
					myComPort.Close();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("reset error failed");
			}
		}

		public void setSpeed(int a)
		{
			try
			{
				if (!myComPort.IsOpen)
				{
					myComPort.Open();
				}
				if (myComPort.IsOpen)
				{
					myComPort.Write("SP " + a + "\n");
					myComPort.Close();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("speed failed");
			}
		}


		// Move the Body Left and Right
		public void moveBody(int a, int b)
		{
			Console.WriteLine("a: " + bodyLeftRight + " b: " + bodyUpDown);

			try
			{
				if (!myComPort.IsOpen)
				{
					myComPort.Open();
				}
				if (myComPort.IsOpen)
				{
					if (!myComPort.CtsHolding && myComPort.DsrHolding)
					{
						if (bodyLeftRight >= -5900 && bodyLeftRight <= 5900)
						{
							if (bodyUpDown >= 1700 || bodyUpDown <= -1700)
							{
								b = 0;
							}

							myComPort.WriteLine("MI" + a + "," + b + "," + b + ",-0,-0,-0");
							bodyLeftRight += a;
							bodyUpDown += b;
						}

					}
					myComPort.Close();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("move failed");
			}
		}












	}
}
