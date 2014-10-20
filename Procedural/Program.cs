using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedural
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string negro = "#";
            string blanco = " ";

            for (int linea = 0; linea < 4; linea++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int n = 0; n < 4; n++)
                            Console.Write(negro);
                        for (int b = 0; b < 5; b++)
                            Console.Write(blanco);
                    }
                    Console.WriteLine();
                }
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int b = 0; b < 5; b++)
                            Console.Write(blanco);
                        for (int n = 0; n < 4; n++)
                            Console.Write(negro);
                    }
                    Console.WriteLine();
                }
            }

            Console.Read();
        }
    }
}
