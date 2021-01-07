using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIPROJECT
{
    class ValidationClass
    {

        //To use this function
        //String err = "";
        //Object data = ValidationClass.isPositiveInteger("3",err);
        // int x = (int)data;
        public static Object isPositiveInteger(String input, StringBuilder err)
        {
            Object returnData = null;
            try
            {
                int x = Convert.ToInt32(input);
                if (x < 0)
                {
                    err.Append("Input " + input + " is a negative number");
                }
                else
                {
                    returnData = x;
                }
            }
            catch
            {
                err.Append("Input " + input + " is not a valid integer");
            }
            return returnData;
        }



         public static Object IsValidYear(String yy, StringBuilder err)
        {
            Object returnData = null;
            try
            {
                int y = Convert.ToInt32(yy);
                if (y > 2020 || y < 1900)
                {
                    err.Append("Input " + y + " is out of boundaries");
                }
                else
                {
                    returnData = y;
                }
            }
            catch
            {
                err.Append("Input " + yy+ " is not a valid year");
            }
            return returnData;
        }

       
    }

}


