using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata3.Kata4Classes
{
    public class DRYFusion
    {

        public int GetLowestChange(string[] textArray, string kindOfSearch)
        {
            int firstValue;
            int secondValue;

            if (kindOfSearch == "weather")
            {
                firstValue = 1;
                secondValue = 2;
            }
            else
            {
                firstValue = 6;
                secondValue = 8;
            }

            int lowestValue = -1;

            foreach (string element in textArray)
            {
                string[] splitted = element.Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (splitted.Length == 0 || splitted.Length == 1)
                    continue;

                if (int.TryParse(splitted[firstValue], out _) && int.TryParse(splitted[secondValue], out _))
                {
                    int comparisionValue = Math.Abs(int.Parse(splitted[firstValue]) - int.Parse(splitted[secondValue]));

                    bool isSmallerThanLowest = comparisionValue < lowestValue;

                    if (isSmallerThanLowest || lowestValue == -1)
                        lowestValue = comparisionValue;

                }
            }

            return lowestValue;
        }
    }
}
