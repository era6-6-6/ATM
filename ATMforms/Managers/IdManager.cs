using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMforms.Managers
{
    class IdManager
    {
        public int ID()
        {
            Random a = new Random();

            return a.Next();

        }
    }
}
