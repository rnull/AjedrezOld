using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Renglon
    {
        private Casilla[] casillas = new Casilla[8];

        public Renglon(Casilla[] Casillas)
        {
            this.casillas = Casillas;
        }

        public void PintaRenglon()
        {

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(casillas[i].contenido[j]);
                }
                Console.WriteLine();
            }
        }

        public Casilla GetCasilla(int i)
        {
            return casillas[i];
        }

        public void SetCasilla(Casilla c, int i)
        {
            casillas[i] = c;
        }
        
    }
    
}