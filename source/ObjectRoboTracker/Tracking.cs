using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Object_Robo_Tracker
{
	class TrackFilteredObject
	{
		public void searchForMovement(Mat thresholdImage, Mat cameraFeed, Mat boundImage, int nr, TheObject myObject, Mat miniPicture)
		{
			int centerX = 0, centerY = 0;

			// for detection
			Mat tempImage = new Mat();
			thresholdImage.CopyTo(tempImage);
			cameraFeed.CopyTo(boundImage);

			double minVal, maxVal;
			Point minLoc, maxLoc;

			Mat resulted = new Mat();
			miniPicture.CopyTo(resulted);

			//find contours in our image
			MatOfPoint[] contours = Cv2.FindContoursAsMat(tempImage, ContourRetrieval.External, ContourChain.ApproxNone);
			//if contours vector is not empty, we have found some objects
			//if robot doesnt move track my next object
			if (GlobalVars.trackingRobot == false)
			{
				if (contours.Length > 0 && contours.Length < 3)
				{

					// we have he a line of point p1, p2, pN... and then find that center
					foreach (MatOfPoint contour in contours)
					{
						// reset centers
						centerX = 0;
						centerY = 0;

						if (contour.Count > GlobalVars.minObjectSize && contour.Count < GlobalVars.maxObjectSize)
						{
							// for each point in the contour ... contour count give you the hight x witdh
							for (int ii = 0; ii < contour.Count; ii++)
							{
								// get point
								Point pts = contour.At<Point>(ii);
								Cv2.Circle(boundImage, pts, 1, GlobalVars.greenCvDrawColor);

								// set X Y
								centerX += pts.X;
								centerY += pts.Y;
							}

							// set center
							centerX /= contour.Count;
							centerY /= contour.Count;

							// add center
							myObject.setTheObject(centerX, centerY);

							// for compare when to much noise
							IplImage detectedObjecPicture = cameraFeed.ToIplImage();
							CvRect roiRect = new CvRect(myObject.getTheObjectX() - 40, myObject.getTheObjectY() - 30, 80, 60);
							// Refion of Interest when the Object is big we want keep te last track
							Cv.SetImageROI(detectedObjecPicture, roiRect);
							Mat regionOfInterestiImage = new Mat(detectedObjecPicture);

							regionOfInterestiImage.CopyTo(miniPicture);

						}
					}
				}
				else
				{
					// keep track of the object if we dont have a 80% match the object the doesn´t exist anymore
					try
					{
						resulted = cameraFeed.MatchTemplate(miniPicture, MatchTemplateMethod.CCoeffNormed);
						resulted.MinMaxLoc(out minVal, out maxVal, out minLoc, out maxLoc);

						if (maxLoc.X != 0 && maxVal > 0.80)
						{
							myObject.setTheObject(maxLoc.X + 40, maxLoc.Y + 30);
						}
						else
						{
							myObject.setTheObject(0, 0);
						}
					}
					// the object doesn´t exist anymore
					catch { }
				}
			}
		}


		public void drawMyObejct(Mat cameraFeed, TheObject myObject)
		{
			int x = 0, y = 0;
			x = myObject.getTheObjectX();
			y = myObject.getTheObjectY();
			//draw some circle around the object
			CvPoint drawPoint = new CvPoint(x - 10, y - 10);
			Cv2.Circle(cameraFeed, drawPoint, 20, GlobalVars.greenCvDrawColor, 20);

		}


	}
}
