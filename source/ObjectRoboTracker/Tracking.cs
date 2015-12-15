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
            bool objectDetected = false;
            int centerX = 0, centerY = 0;

            // for detection
            Mat tempImage = new Mat();
            thresholdImage.CopyTo(tempImage);
            cameraFeed.CopyTo(boundImage);

            double minVal, maxVal;
            Point minLoc, maxLoc;

            Mat resulted = new Mat();
            miniPicture.CopyTo(resulted);

            //Start
            MatOfPoint[] contours = Cv2.FindContoursAsMat(tempImage, ContourRetrieval.External, ContourChain.ApproxNone);
            //if contours vector is not empty, we have found some objects
            if (contours.Length > 0 && contours.Length < 3) objectDetected = true;
            else
            {
                objectDetected = false;

                // keep track of the object if we dont have a 85% match the object does not move anymore or is gone
                try
                {
                    resulted = cameraFeed.MatchTemplate(miniPicture, MatchTemplateMethod.CCoeffNormed);
                    resulted.MinMaxLoc(out minVal, out maxVal, out minLoc, out maxLoc);
                    
                    
                    if (maxLoc.X != 0 && maxVal > 0.85)
                    {
                        myObject.setTheObject(maxLoc.X+40, maxLoc.Y+30);
                        //Console.WriteLine("maxLoc: {0}, maxVal: {1}", maxLoc, maxVal);
                    }
                    else
                    {
                        myObject.setTheObject(0, 0);
                    }
                }
                catch { }

            }

            if (objectDetected)
            {
                // we have he a line of point p1, p2, pN... and then find that center
                foreach (MatOfPoint contour in contours)
                {
                    // reset centers
                    centerX = 0;
                    centerY = 0;

                    if (contour.Count > GlobalVars.MIN_OBJECT_SIZE && contour.Count < GlobalVars.MAX_OBJECT_SIZE)
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
