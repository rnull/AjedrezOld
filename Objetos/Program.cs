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
            for (int a = 0; a <= 123454; a++)
            {//Ciclado del programa
                for (int k = 0; k <= 5342312; k++)
                {
                    // Modificar coordenadas A-H && 1-8

                    Console.Write("Escribe tus coordenas [fila] [columna]:  ");
                    string coordenadas = (Console.ReadLine());

                    char cf = coordenadas[0];
                    char cc = coordenadas[2];
                    int cf1 = 0;

                    if (cf == 'A') { cf1 = 8; }
                    if (cf == 'a') { cf1 = 8; }
                    if (cf == 'B') { cf1 = 7; }
                    if (cf == 'b') { cf1 = 7; }
                    if (cf == 'C') { cf1 = 6; }
                    if (cf == 'c') { cf1 = 6; }
                    if (cf == 'D') { cf1 = 5; }
                    if (cf == 'E') { cf1 = 4; }
                    if (cf == 'F') { cf1 = 3; }
                    if (cf == 'G') { cf1 = 2; }
                    if (cf == 'H') { cf1 = 1; }

                    int cc1 = int.Parse(cc.ToString());


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
                "$$$$","$$$$","$$$$","$$$$"};

                    temp.contenido = nuevoContenido;
                    renglones[cf1 - 1].SetCasilla(temp, cc1 - 1);

                    Console.WriteLine("\n\n\n");
                    for (int i = 0; i < 8; i++)
                    {
                        renglones[i].PintaRenglon();
                    }
                }
            }
        }
    }
}
