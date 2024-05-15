using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_And_Abstraction_Exercises
{
    public class StationaryPhone : Phones, ICallable
    {
        
        public void PrintCalledNumber(string number)
        {
            if (IsValidNumber(number))
            {
                Console.WriteLine("Dialing... " + number);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            
        }
    }
}
