using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessThan1Year
{
    public class TimeCalculator
    {
        /// <summary>
        /// Returns true if the end date is less than one year after the start
        /// date. The time component will be considered when determining the
        /// result.
        /// </summary>
        /// <param name="startDate">The start date and time.</param>
        /// <param name="endDate">The end date and time.</param>
        /// <returns>True if the range is less than one year, false
        /// otherwise.</returns>
        public static bool IsDurationLessThanOneYear(DateTime startDate, DateTime endDate)
        {
            if (DateTime.Compare(startDate, endDate) > 0)
                throw new ArgumentException();
 
            if (endDate.Year > startDate.Year + 1)
                return false;
            else
            {
                if (endDate.Year > startDate.Year)
                {
                    if (endDate.Month > startDate.Month)
                        return false;
                    else
                    {
                        if (endDate.Day >= startDate.Day)
                            return false;
                    }
                }
            }
            
            return true;
        }
    }
}
