using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            //bloco de função
            //Linguagem fortemente tipada, podendo definir vários tipos de váriaveis
            // Booleano em C# se chama Bool
            double raio = 4.5; // tipo de variavel que foi tipada para valores decimais 
            const double raio2 = 3.12;
            double area = raio2 * raio;

            bool SimOunao = false;

            Console.WriteLine("A área é" + area);
            if (area > 0) {
                Console.Write("A área já ultrapassou 0, logo continuaremos nossa verificação");
                if (area > 0) {
                    double newvalor = area / raio2 * raio;
                    Console.WriteLine("Novo valor da área é " + newvalor);
                }
            }
            if (SimOunao = false) {
                Console.Write("No caso o sistema está detectando um valor booleano como false, vamos muda-lo para true");

                SimOunao = true;
            }
            if (SimOunao = true) {
                Console.WriteLine("Agora o sistema está reconhecendo o valor como verdadeiro" + SimOunao);
            };
            byte idade = 45;
            Console.WriteLine("Idade " + idade);
            // byte para economizar memória muito bom estudar a fundo sobre suas áreas de aplicação
            //sbyte ele aceita sinais, vai de 127 até 128 bits, algo necessário para estudar segurança da informação. Suporta valores negativos, ele também aceita sinais.Menor valor 127 maior 128

            short salario = short.MaxValue;
            Console.WriteLine("Salario" + salario);
            int Menorvalor = int.MinValue; //Mais usado dos inteiros;
            Console.WriteLine("Menor Int" + Menorvalor);
            uint populacaoBr = 200_123_123; // uint server para usar sinais, é fantastico como é fortemente tipada essa lingaguem.
            Console.WriteLine("População Br" + populacaoBr + "Menor valor " + Menorvalor);
            ulong populacaoMundial = 7_600_000_000; //No C# cada tipagem tem limites de bitys, logo tem que ficar atento ao tipo de entrada de dados que eu estou insirindo.

            float valorliteral = 1232.00f; //Sempre tem que ter o F para deixar do tipo Float, por padrão os valores sempre vem em Doble, que tem 4 vezes mais espaço de armazenamento. Float 4 bits Doble 8 bits

            Console.WriteLine("Valor do pcgamer" + valorliteral);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;//Professor sempre priorizar o doble, por que quando tem conversão de doble para float, a perda de dados caso o dados do doble ultrapassem 4 bits. Para segurança de dados é algo muito bom, gostei dessas tipagem.


            decimal distanciadaestrela = decimal.MaxValue; // decimal é para valores astronômicos
            // em C# aspas simples('') só aceita um caracter  ou seja uma unica letra.
            //Aspas duplas aceita até frases e textos igual no Javascript("")
            char aspasimples = ('A');// a utilização do char é somente par aspas simples
            var aspaduplas = ("Olá mundo de novo");
        }
    }
}
