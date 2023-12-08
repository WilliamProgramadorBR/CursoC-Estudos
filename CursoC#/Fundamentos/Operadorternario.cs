using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
    internal class OperadorTernario {
        public static void Executar() {
            Console.Write("Qual é o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite, por favor a nota do aluno :");
            var notaValue = Console.ReadLine();
            double nota = Convert.ToDouble(notaValue);
            var media = nota / 4;
            string resultado = $"O aluno:   {nome} está : " +  (media >= 7.0 ? "Aprovado" : "Reprovado") + $" com uma média de {media}" ; // Aqui nós podemos ver a mágia do operador Ternario, caso seja true Aprovado, caso seja False Reprovado
            Console.WriteLine(resultado);


        }
    }
}
