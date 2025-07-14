using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_studying
{
    public class Live : Delivery
    {
        public override void Deliver()
        {
            Console.WriteLine("Live Delivery Type");
        }
    }
}
