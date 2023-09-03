using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOf_2
    {
        public PowerOf_2(int n) { 
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}
