using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Robo_Tracker
{
	class theObject
	{
		int x;
		int y;

		public theObject()
		{
			x = 0;
			y = 0;
		}

		public void setTheObject(int x, int y)
		{
			this.x = x;
			this.y = y;
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
