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

        public void moveBodyLeftRight(int direction)
        {

        }

        //
        // This is the main Routine for the Robot
        //
        public void movementRoutine()
        {
            while (GlobalVars.robotRoutine)
            {
                while (GlobalVars.robotCanMove)
                {
                    Thread.Sleep(1000);

                    moveBody(GlobalVars.theFinalObject1[0]);

                }
            }
        }

        // Returns Robot to Nest Position
        public void moveNest()
        {
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


        // Move the Body Left and Right
        public void moveBody(int a)
        {
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
                        myComPort.WriteLine("MI" + a + ",-0,-0,-0,-0,-0");
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
