using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
     class OperadoresAritmeticos {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;
            // lembrando que acima estamos fazendo uma inferencia, diferente do nosso amigo javascript, o C# tipa as variaveis, ou seja, a preco está no tipo Double, caso diminua a quantidade de numeros e remova o ponto, ela seria tipo int. Fique atento ao usar var para definir entrada de dados.
            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine($"O preço total é {totalComDesconto}");

            // vamos fazer um IMC
            Console.WriteLine("Qual é o seu peso?");
            string pesotext = Console.ReadLine();
            Console.WriteLine("Digite a sua altura :");
            string alturatext = Console.ReadLine();
            double peso = Convert.ToDouble(pesotext); double altura = Convert.ToDouble(alturatext);
            double imc = peso/ Math.Pow(altura, 2 );//Math.Pow, é para fazer a altura elevado a potencia, logo daria o mesmo valor do que altura vezes 2
            Console.WriteLine($"Valor do Imc calculado em base ao seu peso é de {imc}");

            int par = 24;
            int impar = 55;

            Console.WriteLine("{0}/2 tem resto {1}", par, par %2);// aqui é apenas uma lógica matemática, numero par, sempre é divísivel por 2
            Console.WriteLine("{0}/2  tem resto {1}", impar, impar % 2);// numero impar, sempre resta 1 

            // aqui vamos fazer uma brincadeira, eu tenho bastante conhecimento em lógica e ainda por cima programo em javascript, principalmente em node.js
            // vou tentar aplicar algumas coisas como bloco de funções ou até pequenos blocos de ifs

            if (imc < 18) {
                Console.WriteLine("Você está abaixo do peso, procure um nutricionista e vá ao médico");
                return;
            }if(imc >= 19 && imc <= 25) {
                Console.WriteLine("Uau, sua alimentação está indo bem, continue assim. Beba bastante aguá e coma frutas que contém bastante aguá, para ficar hidratado");
            };if(imc >= 26 && imc <= 29) {
                Console.WriteLine("Cuidado, você já está no sobrepeso, está na hora de rever a sua alimentação");
            }; if (imc >= 30 && imc <= 34) {
                Console.WriteLine("Sua obesidade está no grau 1 pode começar a trazer problemas a sua saúde, procure um médico e faça atividades fisícas, depois de ter passado por um cardiologista");
            }; if(imc >= 35 && imc <= 39) { Console.WriteLine("Alerta de perigo, por favor cuide bem da sua saúde, evite ao maximo comidas com colesterol elevado"); };
            if(imc >= 40) {
                Console.WriteLine("Perigo severo, consulte urgentimente um posto de saúde, repense melhor sobre oque você come e bebe, você vale muito para se maltratar desse jeito");
            };
            // como pode ver acima, reutilizei alguns conhecimentos de javascript, para deixar o código mais interativo, algo legal pontuar isso.


        }
    }
}
