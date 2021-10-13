using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionTask
{
    static class Extension
    {
        #region
        public static bool Palindrom(this int number)
        {
            int n = 0;
            int result = number;

            while (result > 0)
            {
                n = n * 10 + result % 10;
                result /= 10;
            }
            return n == number;


        }
        #endregion Palindrom Palindrom





    }
}



