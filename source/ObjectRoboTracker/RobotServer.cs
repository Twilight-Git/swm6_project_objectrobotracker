using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Object_Robo_Tracker
{
    class RobotServer
    {
        public RobotServer()
        {
            try
            {
                SerialPort myComPort = new SerialPort("", 9600, Parity.Even, 8, StopBits.One);
                myComPort.RtsEnable = true;
            }
            catch (Exception e)
            {

            }
        }

        public string[] checkComPorts(int ports)
        {
            String[] comPorts = new String[] { };

            comPorts = SerialPort.GetPortNames();

            //for (int i = 0; i <= ports; i++)
            //{
            //    String test = "COM" + i;
            //    try
            //    {
            //        SerialPort.GetPortNames();
            //        SerialPort testPort = new SerialPort(test);
            //        comPorts.Add(test + " is Connected");
            //    }
            //    catch
            //    {
            //        // No Connection on that Port
            //        comPorts.Add(test + " is not Connected");
            //    }

            //}

            return comPorts;
        }
    }
}
