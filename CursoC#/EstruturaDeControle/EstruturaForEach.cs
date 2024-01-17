using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.EstruturaDeControle {
    internal class EstruturaForEach {
        public static void Executar() {
            var palavra = "Seja muito feliz nessa vida, seja grato";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }// ele está partindo um elemento e percorrendo até o ultimo


            var alunos = new String[] { "William", "Jaqueline", "Antonio", "Eduarda" };

            foreach(string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
