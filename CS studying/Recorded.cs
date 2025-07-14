using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_studying
{
    public class Recorded : Delivery
    {
        public override void Deliver()
        {
            Console.WriteLine("Recorded Delivery Type");
        }
    }
}
