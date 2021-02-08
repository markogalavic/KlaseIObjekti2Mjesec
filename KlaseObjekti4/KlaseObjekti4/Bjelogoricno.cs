using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti4
{
    class Bjelogoricno : Stablo
    {

        public string opdajuListovi = "Opadaju Listovi";
        

        
        public Bjelogoricno(string modelState)
        {
            opdajuListovi = modelState;
           
        }

        static void Main(string[] args)
        {
           
        }
    }
}
