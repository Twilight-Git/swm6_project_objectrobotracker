using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Robo_Tracker
{
	class TheObject
	{
		int x;
		int y;
		int camNr;

		public TheObject(int camN)
		{
			this.camNr = camN;
		}


		public TheObject()
		{
			x = 0;
			y = 0;
		}

		public void setTheObject(int xx, int yy)
		{
			this.x = xx;
			this.y = yy;


			// Set here the Globals for Labeldrawing
			GlobalVars.setGlobalObjects(this.camNr, this.x, this.y);
		}

		public int getTheObjectX()
		{
			return this.x;
		}

		public int getTheObjectY()
		{
			return this.y;
		}


	}
}
