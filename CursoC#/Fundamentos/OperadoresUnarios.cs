using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);// Aqui é um operador unario, ele vai inverter o valor do -5 para 5 
            Console.WriteLine(!booleano);// como nós vimos, ele vai inverter o valor de true para false, e assim vice verso 
            numero1++; // Já vimos até muito no javascript, estamos acrescentando um valor a esta unidade, o mesmo que numero1 + 1
            Console.WriteLine(numero1);
            --numero1;// Aqui também já utilizamos, estar decrementando o valor, tirando uma unidade numero2 - 1;
            Console.WriteLine(numero2);

            // vamos para outro exemplo
            Console.WriteLine(numero1++ == --numero2);//Algo a ser notado, a segunda condição --numero2 o valor será descrementado antes da operação, isso é importante quando eu quero executar a incrementação ou a descrementação antes de executar uma condição ou outro código
            Console.WriteLine($"{numero1}{numero2}");// aqui vai ter valores diferente, mais na linha de cima, os valores vai ser igual porque o decremento é feito antes da execução da comparação, porque o valor vem na frente Expl: --numero2
            // O código acima, não é ideal, vc pode notar que é um código de dificil leitura, procure estudar mais para melhorar o código
        }
    }
}
