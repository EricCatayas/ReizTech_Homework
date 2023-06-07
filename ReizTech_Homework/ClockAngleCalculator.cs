using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_Homework
{
	public class ClockAngleCalculator
	{
		public static double GetClockAngle(int hour, int minute)
		{
			// Validate the input values
			if (hour < 0 || hour > 12)
			{
				throw new ArgumentException("Invalid hour input");
			}
			if (minute < 0 || minute > 59)
			{
				throw new ArgumentException("Invalid minute input");
			}

			// Calculate the angles of the hour and minute hands
			double hourAngle = 0.5 * (60 * hour + minute);
			double minuteAngle = 6 * minute;

			// Calculate the absolute difference between the angles
			double angleDiff = Math.Abs(hourAngle - minuteAngle);

			// Get the lesser angle between the two
			double lesserAngle = Math.Min(angleDiff, 360 - angleDiff);

			return lesserAngle;
		}
	}
}
