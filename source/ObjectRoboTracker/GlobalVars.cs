using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Robo_Tracker
{
    public class GlobalVars
    {
        public static bool switchedCams = false;

        private static int[] theTmpObject1 = new int[2] { 0, 0 };
        private static int[] theTmpObject2 = new int[2] { 0, 0 };

        public static bool robotRoutine = false;
        public static bool robotCanMove = false;

        public static int[] theFinalObject1 = new int[2] { 0, 0 };
        public static int[] theFinalObject2 = new int[2] { 0, 0 };

        public static int H_MIN = 0;
        public static int H_MAX = 256;
        public static int S_MIN = 0;
        public static int S_MAX = 256;
        public static int V_MIN = 0;
        public static int V_MAX = 256;

        public static int MIN_OBJECT_SIZE = 200;

        public static int SENSITIVITY_VALUE = 20;
        public static int BLUR_SIZE = 20;

        public static Size blurSz = new Size(GlobalVars.BLUR_SIZE, GlobalVars.BLUR_SIZE);

        public static CvScalar MIN_HSV_Scalar = new CvScalar(H_MIN, S_MIN, V_MIN);
        public static CvScalar MAX_HSV_Scalar = new CvScalar(H_MAX, S_MAX, V_MAX);


        public static CvScalar greenCvDrawColor = new CvScalar(0, 255, 0);

        //public static Rect objectBoundingRectangle = new Rect(0, 0, 0, 0);


        public static Boolean abort = false;

        public static void updateScalar()
        {
            MIN_HSV_Scalar.Val0 = H_MIN;
            MIN_HSV_Scalar.Val1 = S_MIN;
            MIN_HSV_Scalar.Val2 = V_MIN;

            MAX_HSV_Scalar.Val0 = H_MAX;
            MAX_HSV_Scalar.Val1 = S_MAX;
            MAX_HSV_Scalar.Val2 = V_MAX;

            blurSz.Height = BLUR_SIZE;
            blurSz.Width = BLUR_SIZE;

        }


        
        public static void setGlobalObjects(int camNr, int x, int y)
        {
            switch (camNr)
            {
                case 0:
                        GlobalVars.theTmpObject1[0] = x-320;
                        GlobalVars.theTmpObject1[1] = -y+240;
                    break;

                case 1:
                        GlobalVars.theTmpObject2[0] = x-320;
                        GlobalVars.theTmpObject2[1] = -y+240;
                    break;
            }
            if (GlobalVars.switchedCams)
            {
                GlobalVars.theFinalObject1 = GlobalVars.theTmpObject2;
                GlobalVars.theFinalObject2 = GlobalVars.theTmpObject1;
            }
            else
            {
                GlobalVars.theFinalObject1 = GlobalVars.theTmpObject1;
                GlobalVars.theFinalObject2 = GlobalVars.theTmpObject2;
            }
        }


    }
}
