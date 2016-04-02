using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongPairing
{
    public class Countdown
    {
        public int[] countdown (int start)
        {
            int num = 0;
            int[] returning = new int[start+1];
            for (int i = start; i >= 0; i--)
            {
                returning[num] = i;
                num++;
            }
            return returning;
        }
    }
}
