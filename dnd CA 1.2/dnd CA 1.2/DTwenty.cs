using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_CA_1._2
{
    class DTwenty
    {
        public static int D20()
        {
            Random random = new Random();
            return random.Next(1, 21);
        }
        public DTwenty()
        {

        }
    }
}
