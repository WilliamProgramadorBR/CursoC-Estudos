using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            // aqui iremos abordar o assunto sobre operadores lógicos, é algo interessante para usar dentro de blocos de condições
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou a Tv 50 ?  {comprouTv50}"); // aqui retorna falso, porque apenas o trabalho1 vem como true, logo precisava dessas duas condições trues para retorna um true nesse operador

            // Vamos para o próximo operador lógico

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou o sorvetinho para refrescar ?  {comprouSorvete}");// deu verdareiro, porque ele precisava apenas de umas das condições retornando true para consegui comprar o sorvete

            // Vamos para o próximo operador lógico
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"A de 50 não deu, porém a de 32 dar  ?  {comprouTv32}");// Esse é um pouco diferente do segundo, logo retorna verdadeiro por as condições retornaram false e true, logo se ambas fossem false ou true, o operador lógico retornaria false, vamos entender a lógica abaixo:
            // CONTINUAÇÃO: Se o fulano trabalhou na terça trabalho1, e não trabalhou na quarta(trabalho2), logo ele teve dinheiro para comprar a tv de 32, se ele trabalhasse tanto na terça e na quarta, ele teria condição para pagar a tv 50, então a tv de 32 retornaria false, se caso ele não trabalhasse, na terça e na quarta, a condição iria ser false, porque ele não teria dinheiro para comprar nem a tv de 32, logo esse operador ele atua nessa ação, essa é a diferença desse operador com o de cima. 
            // operadores que atuam em dois cenários, true ou false, são operadores  binário, tem outros tipos de operadores para aprofundar e melhorar o código
            Console.WriteLine($"Comprou o sorvetinho para refrescar, abaixou a temperatura ?  {!comprouSorvete}"); // agora é a negação lógica é um operador unario, porque simplesmente ele inverte o valor de um determinado operando
        }
    }
}
