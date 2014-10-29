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
            {
                for (int k = 0; k <= 5342312; k++)//Ciclado del programa
                {
                    // Modificar coordenadas A-H && 1-8

                    Console.Write("\n Escribe tus coordenas [fila] [columna]: ");
                    string coordenadas = (Console.ReadLine());

                    char cf = coordenadas[0];
                    char cc = coordenadas[2];
                    int cf1 = 0;

                    if ((cf == 'A') || (cf == 'a')) { cf1 = 8; }
                    else if ((cf == 'B') || (cf == 'b')) { cf1 = 7; }
                    else if ((cf == 'C') || (cf == 'c')) { cf1 = 6; }
                    else if ((cf == 'D') || (cf == 'd')) { cf1 = 5; }
                    else if ((cf == 'E') || (cf == 'e')) { cf1 = 4; }
                    else if ((cf == 'F') || (cf == 'f')) { cf1 = 3; }
                    else if ((cf == 'G') || (cf == 'g')) { cf1 = 2; }
                    else if ((cf == 'H') || (cf == 'h')) { cf1 = 1; }
                    else
                    {
                        Console.WriteLine("Movimiento no permitido");
                        cf1 = 0;
                    }

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

                    string[] nuevoContenido = new string[4] { "$$$$", "$$$$", "$$$$", "$$$$" };

                    if (cf1 > 0)//Condición para denegar el movimiento si no esta dentro de los parametros
                    {
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
}
