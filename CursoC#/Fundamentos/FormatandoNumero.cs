using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoC_.Fundamentos {
    internal class FormatandoNumero {

        public static void Executar(){
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));// transformando valor numérico para string
            Console.WriteLine(valor.ToString("C"));//convertendo para moeda
            Console.WriteLine(valor.ToString("P"));//convertendo para percentual
            Console.WriteLine(valor.ToString("#.##"));//convertendo para numero decimal

            CultureInfo cultura = new CultureInfo("pt-BR");// usando o import vc pode também escolher a cultura 
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));// No caso está inserindo a quantidade de 0s para pode  ter uma quantidade de caracter 10 
        }
    }
}
