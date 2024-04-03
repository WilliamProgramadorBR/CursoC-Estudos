using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.ClassesEMetodos {

    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }
        public int Multiplicar(int a, int b) { return a * b; }
        public int Divide(int a, int b) { return a / b; }
    }
    class CalculadoraCadeia {
        int memoria;
        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }

    }
    internal class MetodosComRetorno {
        public static void Executar() {
            var CalculadoraComum = new CalculadoraComum();

            var resultado = CalculadoraComum.Somar(5, 5);
            Console.WriteLine(CalculadoraComum.Subtrair(5, 5));
            Console.WriteLine(CalculadoraComum.Multiplicar(5, 5));
            Console.WriteLine(CalculadoraComum.Divide(5, 5));
            Console.WriteLine(CalculadoraComum.Somar(5, 5));


            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            //Podemos ver conceitos diferentes de OO, amei atuar com o This, no javascript n extraia muito bem a sua funcionalidade.
            //Ai podemos ver, dois método, foca e estude o do this, o código ficou mais limpo, reutilizavel!
        }
    }
}
