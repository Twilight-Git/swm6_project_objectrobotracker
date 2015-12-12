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

        public static CvScalar drawColor = new CvScalar(0, 255, 0);

        public static int[] theObject1 = new int[2] { 0, 0 };
        public static int[] theObject2 = new int[2] { 0, 0 };

        public static Rect objectBoundingRectangle = new Rect(0, 0, 0, 0);


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


    }
}
