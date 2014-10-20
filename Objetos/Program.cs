using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Renglon[] renglones = new Renglon[8];
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                    renglones[i] = new Renglon(Casilla.GetCasillas(new Simbolo('#')));
                else
                    renglones[i] = new Renglon(Casilla.GetCasillas(new Simbolo(' ')));
            }

            //for (int i = 0; i < 8; i++)
            //{
            //    renglones[i].PintaRenglon();
            //}

            Casilla temp = new Casilla(new Simbolo(' '));// = renglones[0].GetCasilla(0);

            string[] nuevoContenido = new string[4]{
                "$$$$","$$$$","$$$$","$$$$"
            };
            temp.contenido = nuevoContenido;
            renglones[2].SetCasilla(temp, 6);

            Console.WriteLine("\n\n\n");
            for (int i = 0; i < 8; i++)
            {
                renglones[i].PintaRenglon();
            }


            Console.Read();
        }
    }
}
