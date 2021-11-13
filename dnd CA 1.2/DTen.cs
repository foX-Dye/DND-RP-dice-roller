using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_CA_1._2
{
    class DTen
    {
        public int D10()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }
        public DTen()
        {

        }
    }
}
