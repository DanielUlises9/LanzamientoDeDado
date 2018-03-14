using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoDeDado
{
    class Dado
    {
        private int _dado;
        Random r = new Random();


        public int Lanzamiento()
        {
            int cara = r.Next(1,7);
            return cara;
        }
    }
}
