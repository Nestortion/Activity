using System;
using System.Collections.Generic;
using System.Text;

namespace Activity
{
	class QualityChecker
	{
		public static bool CheckQuality(Product p)
		{
			if (p.Condition == "Good")
			{
				return true;
			}
			else
			{
				return false;
			}

		}
	}

}
