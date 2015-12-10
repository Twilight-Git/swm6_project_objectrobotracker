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
        public void searchForMovement(Mat thresholdImage, Mat cameraFeed, Mat boundImage, int nr)
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

                            Cv2.Circle(boundImage, pts, 1, GlobalVars.drawColor);

                            // set X Y
                            centerX += pts.X;
                            centerY += pts.Y;
                        }

                        // set center
                        centerX /= contour.Count;
                        centerY /= contour.Count;

                        // add center
                        switch (nr)
                        {
                            case 0:
                                GlobalVars.theObject1[0] = (int)centerX;
                                GlobalVars.theObject1[1] = (int)centerY;
                                break;

                            case 1:
                                GlobalVars.theObject2[0] = (int)centerX;
                                GlobalVars.theObject2[1] = (int)centerY;
                                break;
                        }
                    }
                }
            }
            //make some temp x and y variables so we dont have to type out so much
             int x=0, y=0;

            switch (nr)
            {
                case 0:
                    x = GlobalVars.theObject1[0];
                    y = GlobalVars.theObject1[1];
                    break;

                case 1:
                    x = GlobalVars.theObject2[0];
                    y = GlobalVars.theObject2[1];
                    break;
            }
            //draw some circle around the object
            CvPoint drawPoint = new CvPoint(x, y);
            Cv2.Circle(cameraFeed, drawPoint, 20, GlobalVars.drawColor, 2);
        }

    }
}
