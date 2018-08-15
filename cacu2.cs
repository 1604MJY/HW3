using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitCacu
{
    public class Cacu2
    {
        static public double Cacu2(Circuit object)
        { double Resisnum,current;
            Resisnum = (object.Resis2 * object.Resis4) / (object.Resis2 + object.Resis4);
            current = Math.Round((object.Voltage / (object.Resis1 + Resisnum)) + (object.Voltage / object.Resis3),3);
            return current;
        }
    }
}
