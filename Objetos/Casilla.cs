using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Casilla
    {
        private Simbolo color;
        public string[] contenido = new string[4];
        public Casilla(Simbolo Color)
        {
            this.color = Color;
            llenarCasilla(color);
        }
        private void llenarCasilla(Simbolo color)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    contenido[i] += color.Caracter;
                }
        }

        public static Casilla[] GetCasillas(Simbolo color)
        {
            Casilla[] _casillas = new Casilla[8];
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    if (color.Caracter == ' ')
                    {
                        _casillas[i] = new Casilla(new Simbolo(' '));
                        _casillas[i + 1] = new Casilla(new Simbolo('#'));
                    }
                    if (color.Caracter == '#')
                    {
                        _casillas[i] = new Casilla(new Simbolo('#'));
                        _casillas[i + 1] = new Casilla(new Simbolo(' '));
                    }
                }
            }
                return _casillas;
        }
    }
}
