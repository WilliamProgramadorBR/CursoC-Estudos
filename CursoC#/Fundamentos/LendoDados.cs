using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks; //COmo se fosse import no javascript, procura entender melhor sobre

namespace CursoC_.Fundamentos {
     class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.Write("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());// convertento string em numero

            Console.Write("Qual  é o seu salário?");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"{nome} a sua idade é {idade} e você fatura cerca de ${salario} mensal");
        }
    }
}
