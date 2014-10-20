using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Simbolo
    {
        private char caracter;
        public char Caracter
        {
            get { return caracter; }
        }

        public Simbolo()
        {
            caracter = ' ';
        }

        public Simbolo(char Caracter)
        {
            this.caracter = Caracter;
        }
    }
}
