using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Mechanic
{
    public static class Rng
    {
        public static Random rng;
        static Rng()
        {
            rng = new Random(1);
        }
    }
}
