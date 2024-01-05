using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.EstruturaDeControle {
    internal class EstruturaIfElseIf {
        public static void Executar() {
            Console.Write("Digite a nota do aluno: ");
            
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);
            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            if (nota >= 9.0) {
                Console.WriteLine($"{nomeAluno} entrou no quadro de honra! com a nota de {nota}");
            }
            else if (nota >= 7.0 && nota < 9.0) {
                Console.WriteLine($"O aluno {nomeAluno} foi aprovado com a nota de {nota}");
            }
            else if (nota >= 5.0 && nota < 7.0) {
                Console.WriteLine($"O aluno {nomeAluno} está em recuperação! A nota dele é {nota}");
            }
            else { Console.WriteLine("Te vejo na próxima"); }
            Console.WriteLine("Programa encerrado");

        }
    }
}
