using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar() {
            //double nota = 6.0;
            double notaDecorte = 7.0;
            Console.Write("Digite a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota);
           

            Console.WriteLine("Nota inválida ?{0}", nota > 10.0);// Logo podemos verificar, que o {0} ele siginifica valor binário, true e false. Assim podemos fazer diversas coisas com este cenário
            Console.WriteLine("Nota zero é maior que a nota do aluno? {0}", nota < 0.0);
            Console.WriteLine("A nota do aluno pode melhorar? {0}", nota != 10.0);
            Console.WriteLine("Aluno atingiu a excelência? {0}", nota == 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDecorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDecorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);

            // acima todos os operadores relacionais, logo quando eu tiver com tempo, irei criar uma prova de seleção, assim dar para a gente brincar com esse código.

            


        }
    }
}
