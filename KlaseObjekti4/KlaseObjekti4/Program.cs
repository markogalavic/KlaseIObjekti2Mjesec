using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bjelogoricno Hrast = new Bjelogoricno("OpadajuListovi");
            Console.WriteLine(Hrast.opdajuListovi);

            Crnogoricno Bor = new Crnogoricno("NeOpadajuListovi");
            Console.WriteLine(Bor.neOpdajuListovi);

            Console.WriteLine(Hrast.opdajuListovi,Bor.neOpdajuListovi);
        }
    }
}
