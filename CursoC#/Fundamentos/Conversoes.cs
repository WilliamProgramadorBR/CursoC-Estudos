using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
   class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;// isso é uma conversão, transformamos  um inteiro para double
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;// dessa forma estou convertendo um double para int, é necessário fazer dessa forma, já que o compilador acusa erro se apenas tentar fazer a conversão sem indicar para qual tipo de entrada, lembrando em entradas menores como float, pode haver perda de dados
            Console.WriteLine(notaTruncada);// a saida foi 9, houve perda de dados, note que antes era 9.7;
            Console.Write("Digite seu cpf:");
            string cpfString = Console.ReadLine();
            double cpfInteiro = double.Parse(cpfString);
            Console.WriteLine($"Seu cpf é  {cpfInteiro}");  

            //Outra forma de converter
            cpfInteiro = Convert.ToDouble(cpfString); // achei mais atraente converter assim

            Console.WriteLine($"Essa é a nova conversão {cpfInteiro}");
            // 

            Console.WriteLine("Digite um numéro");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);// aqui ele vai converter oque passou dentro da palavra e vai jogar dentro do numero que foi chamado como segundo parametro
            Console.WriteLine($"Resulato do numero é  {numero}");// isso aqui ele pega o valor da string e converter para numero, caso o valor da string n seja um numero válido, logo ele converte para zero, assim evita erro ou crash na aplicação, exemplo string = "Olá mundo", conversão final ficará = 0,  PORQUE OLÁ MUNDO NÃO É UM VALOR NUMÉRICO

        }
    }
}
