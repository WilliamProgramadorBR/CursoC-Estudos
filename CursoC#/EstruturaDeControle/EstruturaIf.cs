using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.EstruturaDeControle {
    internal class EstruturaIf {
        public static void Executar() {
            // Aqui podemos lidar com estrutura de controle, igual nas formas anteriores. 
            bool bomComportamento = false;
            string entrada;
            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);
            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            /*if (entrada == "S" || entrada == "s") {
             //   bomComportamento = true;
            Vamos melhorar o código
            }*/
            bomComportamento = entrada.ToLower() == "s";// ToLower é um ótima prática para converter letras maiúscula em minuscula 
            if (nota >= 9.0 && bomComportamento) {

                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
