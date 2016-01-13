using System;
using System.Collections.Generic;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Extensions;

using System.Management;
using System.Drawing;

namespace Object_Robo_Tracker
{
	class CameraCapure
	{

		public void capture(int cam, PictureBox box1, PictureBox box2, PictureBox box3, PictureBox box4)
		{
			TrackFilteredObject TrackMyMove = new TrackFilteredObject();
			TheObject myObject = new TheObject(cam);
			Console.WriteLine(cam);

			Mat cameraFrame1 = new Mat();
			Mat grayImage1 = new Mat(); ;
			Mat cameraFrame2 = new Mat();
			Mat grayImage2 = new Mat(); ;
			Mat differenceImage = new Mat();
			Mat thresholdImage = new Mat(); ;
			Mat boundImage = new Mat();
			Mat toBm1 = new Mat();
			Mat toBm2 = new Mat();
			Mat toBm3 = new Mat();
			//Mat toBm4 = new Mat(80,60,MatType.CV_8U,3);

			VideoCapture stream = VideoCapture.FromCamera(cam);
			OpenCvSharp.CPlusPlus.Size sz = new OpenCvSharp.CPlusPlus.Size(160, 120);
			Mat toBm4 = new Mat();

			try
			{
				stream.Read(toBm4);
			}
			catch
			{
				GlobalVars.abort = true;
				stream.Dispose();
			}

			while (GlobalVars.abort == false)
			{
				try
				{
					stream.Read(cameraFrame1);     //get first frame form video  
												   //convert frame1 to gray scale for frame differencing
					Cv2.CvtColor(cameraFrame1, grayImage1, ColorConversion.BgrToGray);

					stream.Read(cameraFrame2);      //read second frame
													//convert frame2 to gray scale for frame differencing
					Cv2.CvtColor(cameraFrame2, grayImage2, ColorConversion.BgrToGray);
					//perform frame differencing with the sequential images. This will output an "intensity image"
					//do not confuse this with a threshold image, we will need to perform thresholding afterwards.
					Cv2.Absdiff(grayImage1, grayImage2, differenceImage);
					//threshold intensity image at a given sensitivity value
					Cv2.Threshold(differenceImage, thresholdImage, GlobalVars.sensitivityValue, 255, ThresholdType.Binary);
					//blur the image to get rid of the noise. This will output an intensity image
					Cv2.Blur(thresholdImage, thresholdImage, GlobalVars.blurSizeScalar);
					//threshold again to obtain binary image from blur output
					Cv2.Threshold(thresholdImage, thresholdImage, GlobalVars.sensitivityValue, 255, ThresholdType.Binary);

					TrackMyMove.searchForMovement(thresholdImage, cameraFrame1, boundImage, cam, myObject, toBm4);
					TrackMyMove.drawMyObejct(cameraFrame1, myObject);


					Cv2.Resize(cameraFrame1, toBm1, sz);
					Cv2.Resize(boundImage, toBm2, sz);
					Cv2.Resize(thresholdImage, toBm3, sz);



					box1.Image = toBm1.ToBitmap();
					box2.Image = toBm2.ToBitmap();
					box3.Image = toBm3.ToBitmap();
					box4.Image = toBm4.ToBitmap();

					Cv2.WaitKey(10);

					if (GlobalVars.abort == true)
					{
						break;
					}
				}
				catch (Exception e)
				{
					box1.Image = null;
					box2.Image = null;
					box3.Image = null;
					box4.Image = null;
					GlobalVars.abort = true;
					stream.Dispose();
					toBm1 = null;
					toBm2 = null;
					toBm3 = null;
					toBm4 = null;

				}
			}

			box1.Image = null;
			box2.Image = null;
			box3.Image = null;
			GlobalVars.abort = true;
			stream.Dispose();
			toBm1 = null;
			toBm2 = null;
			toBm3 = null;

		}

		public void cameraPeek(int cam, PictureBox box)
		{
			Mat cameraFrame = new Mat();
			Mat toBm = new Mat();
			Mat toBm2 = new Mat();
			OpenCvSharp.CPlusPlus.Size sz = new OpenCvSharp.CPlusPlus.Size(160, 120);
			VideoCapture stream = new VideoCapture();

			try
			{
				stream = VideoCapture.FromCamera(cam);
				stream.Read(cameraFrame);
				Cv2.Resize(cameraFrame, toBm, sz);
				stream.Dispose();
				box.Image = toBm.ToBitmap();
				box.BackColor = SystemColors.Control;
			}
			catch (Exception e)
			{
				box.InitialImage = null;
				box.Image = null;
				toBm = null;
				box.BackColor = System.Drawing.Color.Tomato;
			}

			stream = null;
		}

	}

}
