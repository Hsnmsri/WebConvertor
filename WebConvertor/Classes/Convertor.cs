using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebConvertor.Classes
{
    static public class Convertor
    {
        static public string PointToDecimalPoint(this object inputString)
        {
            return (inputString.ToString().Replace('.', '/'));
        }
        static public string PointToDecimalPoint(this object inputString, bool reverce)
        {
            string result;
            if (reverce)
                result = inputString.ToString().Replace('/', '.');
            else
                result = inputString.ToString().Replace('.','/');
            return result;
        }
        static public double ToDoubleType(this string inputDouble)
        {
            return (Convert.ToDouble(inputDouble));
        }
    }
}
