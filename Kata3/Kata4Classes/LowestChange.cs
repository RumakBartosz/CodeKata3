using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata3.Kata4Classes
{
    public class LowestChange
    {
        public int GetLowestChange(string[] textArray)
        {
            int lowestValue = -1;

            foreach(string element in textArray)
            {
                string[] splitted = element.Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (splitted.Length == 0 || splitted.Length == 1)
                    continue;

                if (int.TryParse(splitted[1], out _) && int.TryParse(splitted[2], out _))
                {
                    int comparisionValue = Math.Abs(int.Parse(splitted[1]) - int.Parse(splitted[2]));

                    bool isSmallerThanLowest = comparisionValue < lowestValue;

                    if (isSmallerThanLowest || lowestValue == -1)
                        lowestValue = comparisionValue;

                }
            }

            return lowestValue;
        }
    }
}
