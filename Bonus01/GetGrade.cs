using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus01
{
    public class GetGrade
    {


        public string GetGradeLetter(int intGrade)
        {
            string letter = null;

            if (intGrade >= 99)
            {
               letter = "A+";
            }
            else if (intGrade >= 91 && intGrade < 99)
            {
                letter = "A";
            }
            else if (intGrade >= 90 && intGrade < 91)
            {
                letter = "A-";
            }
            else if (intGrade >= 88 && intGrade < 90)
            {
                letter = "B+";
            }
            else if (intGrade >= 81 && intGrade < 88)
            {
                letter = "B";
            }
            else if (intGrade >= 80 && intGrade < 81)
            {
                letter = "B-";
            }
            else if (intGrade >= 78 && intGrade < 80)
            {
                letter = "C+";
            }
            else if (intGrade >= 71 && intGrade < 78)
            {
                letter = "C";
            }
            else if (intGrade >= 70 && intGrade < 71)
            {
                letter = "C-";
            }
            else if (intGrade >= 68 && intGrade < 70)
            {
                letter = "D+";
            }
            else if (intGrade >= 61 && intGrade < 68)
            {
                letter = "D";
            }
            else if (intGrade >= 60 && intGrade < 61)
            {
                letter = "D-";
            }
            else
            {
                letter = "F";
            }
            return letter;

        }
    }
}
