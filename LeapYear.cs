using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if(year%4 == 0) {
                if(year%100 == 0)
                {
                    //for century years like 1900 ,2000
                   if(year%400 == 0)
                    { return true; }
                   else { return false; }
               
                }
                return true;
            }
            return false;

        }
    }
}
