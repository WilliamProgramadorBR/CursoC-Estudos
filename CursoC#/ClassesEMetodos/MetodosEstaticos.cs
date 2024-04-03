using CursoC_.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.ClassesEMetodos {
    public class CalculadoraEstatica {
        public  int Somar(int a, int b) {//método de instância!!!
            return a * b;
        }
        public static int Multiplicar(int a, int b) {// Método de classe ou Método estático!!!
            return a * b;
        }

    }
}
    public class MetodosEstaticos {
    public static void Executar() {
        var resultado = CalculadoraEstatica.Multiplicar(2, 2);
        Console.WriteLine("Resultado: {0}", resultado);

        CalculadoraEstatica calc = new CalculadoraEstatica(); // aqui criamos um construtor para instanciar um obj no qual não está usando o método void
        Console.WriteLine(calc.Somar(2, 2));
    }
}


