using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
     class Comentários {
        public static void  Executar() {
            Console.WriteLine("Olá de novo");
            var calculo1 = 3; var calculo2 = 5;
            
                       //Teste, é parecido com javascript
            var soma = calculo1 + calculo2;
            Console.WriteLine(soma);
            if (soma == 7) {
                Console.WriteLine("O calculo é" + soma);
            }
            else { Console.WriteLine("Not found calculo"); }
        }

    }
}
