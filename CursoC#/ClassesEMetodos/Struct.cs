using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.ClassesEMetodos {
    internal class ExemploStruct {
        interface Ponto {
            void MoverNaDiagonal(int delta);
        }

        struct Coordenada : Ponto {
            public int X;
            public int Y;

            public Coordenada(int x, int y) {
                X = x;
                Y = y;
            }
            public void MoverNaDiagonal(int delta) {
                X += delta;
                Y += delta;
            }

        }
        public static void Executar() {

            Coordenada cooordenadaInicial;
            cooordenadaInicial.X = 2;
            cooordenadaInicial.Y = 5;

            Console.WriteLine("Coordenada final");
            Console.WriteLine("X = {0}", cooordenadaInicial.X);
            Console.WriteLine("Y = {0}", cooordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 9);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);

        }
    }
}
