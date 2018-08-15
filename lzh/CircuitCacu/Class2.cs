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
        {
            double Resisnum, current;
            Resisnum = (object.Resis1 * object.Resis3) / (object.Resis1 + object.Resis3);
            current = Math.Round((object.Voltage / (object.Resis2 + Resisnum)) + (object.Voltage / object.Resis4),3);
            return current;

            
        }
    }
