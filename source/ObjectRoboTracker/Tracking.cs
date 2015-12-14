using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Robo_Tracker
{
    class TrackFilteredObject
    {
        public void searchForMovement(Mat thresholdImage, Mat cameraFeed, Mat boundImage, int nr, TheObject myObject)
        {
            bool objectDetected = false;
            Mat temp = new Mat();
            thresholdImage.CopyTo(temp);
            cameraFeed.CopyTo(boundImage);


            MatOfPoint[] contours = Cv2.FindContoursAsMat(temp, ContourRetrieval.External, ContourChain.ApproxNone);

            //if contours vector is not empty, we have found some objects

            if (contours.Length > 0) objectDetected = true;
            else objectDetected = false;

            if (objectDetected)
            {
                // for each contour
                foreach (MatOfPoint contour in contours)
                {
                    // intialize centers
                    long centerX = 0, centerY = 0;

                    if (contour.Count > GlobalVars.MIN_OBJECT_SIZE)
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
                        myObject.setTheObject((int)centerX, (int)centerY);
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
            CvPoint drawPoint = new CvPoint(x, y);
            Cv2.Circle(cameraFeed, drawPoint, 20, GlobalVars.greenCvDrawColor, 2);
        }


    }
}
