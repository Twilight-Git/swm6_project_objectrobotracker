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
		public static bool trackingRobot = false;

		public static int[] theFinalObject1 = new int[2] { 0, 0 };
		public static int[] theFinalObject2 = new int[2] { 0, 0 };

		public static int hMin = 0;
		public static int hMax = 256;
		public static int sMin = 0;
		public static int sMax = 256;
		public static int vMin = 0;
		public static int vMax = 256;

		public static int minObjectSize = 400;
		public static int maxObjectSize = 800;

		public static int sensitivityValue = 20;
		public static int blurSizeSingle = 40;

		public static Size blurSizeScalar = new Size(GlobalVars.blurSizeSingle, GlobalVars.blurSizeSingle);

		public static CvScalar minHsvScalar = new CvScalar(hMin, sMin, vMin);
		public static CvScalar maxHswScalar = new CvScalar(hMax, sMax, vMax);


		public static CvScalar greenCvDrawColor = new CvScalar(180, 255, 0);

		//public static Rect objectBoundingRectangle = new Rect(0, 0, 0, 0);


		public static Boolean abort = false;

		public static void updateScalar()
		{
			minHsvScalar.Val0 = hMin;
			minHsvScalar.Val1 = sMin;
			minHsvScalar.Val2 = vMin;

			maxHswScalar.Val0 = hMax;
			maxHswScalar.Val1 = sMax;
			maxHswScalar.Val2 = vMax;

			blurSizeScalar.Height = blurSizeSingle;
			blurSizeScalar.Width = blurSizeSingle;

		}



		public static void setGlobalObjects(int camNr, int x, int y)
		{
			switch (camNr)
			{
				case 0:
					if (x != 0 && y != 0)
					{
						GlobalVars.theTmpObject1[0] = x - 320;
						GlobalVars.theTmpObject1[1] = -y + 240;
					}
					else
					{
						GlobalVars.theTmpObject1[0] = 0;
						GlobalVars.theTmpObject1[1] = 0;
					}
					break;

				case 1:
					if (x != 0 && y != 0)
					{
						GlobalVars.theTmpObject2[0] = x - 320;
						GlobalVars.theTmpObject2[1] = -y + 240;
					}
					else
					{
						GlobalVars.theTmpObject2[0] = 0;
						GlobalVars.theTmpObject2[1] = 0;
					}
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
