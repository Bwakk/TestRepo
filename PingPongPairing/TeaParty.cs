using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongPairing
{
    public class TeaParty
    {
        public string welcome(string lastName, bool isWomen, bool isSir)
        {
            if (isWomen)
            {
                return "Ms. " + lastName;
            }
            else if (isSir)
            {
                return "Sir " + lastName;

            }
            else
            {
                return "Mr. " + lastName;
            }
        }
    }
}
