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
            } if (SimOunao = true) {
                Console.WriteLine("Agora o sistema está reconhecendo o valor como verdadeiro" + SimOunao);
            }; 


            Console.Write("Olá mundo");
        }
    }
}
