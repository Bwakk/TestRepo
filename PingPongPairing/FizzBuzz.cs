using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongPairing
{
     public class FizzBuzz
    {
        public string Answer(int number)
        {
            // answer % 3 == 0 && answer % 5 == 0 = "fizzbuzz"
            if (number % 3 == 0 && number % 5 == 0)
                return "fizzbuzz";
            // answer % 3 == 0 = "fizz"
            else if (number % 3 == 0)
                return "fizz";
            // answer % 5 == 0 = "buzz"
            else if (number % 5 == 0)
                return "buzz";
            else
                return number.ToString();
        }
    }
}
