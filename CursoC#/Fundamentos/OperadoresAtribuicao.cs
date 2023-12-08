using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
    internal class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 += 10; // num1 = num1 + 10, ou seja, ele vai somar o valor da váriavel mais 10 Atribuição Somativa
            num1 -= 3; // num1 = num1 - 3; no caso não estamos substituindo o valor, e sim realizando uma soma, tirando 3 da váriavel  Atribuição Subtrativa 
            num1 *= 5; // atriubuição multiplicativa
            num1 /= 2; // atribuição divisível
            Console.WriteLine(num1);

            // vamos ver outros casos de atribuições

            int a = 1; int b = a; // tem como fazer atribuição por cópia e por referência, estude sobre
            // no caso de cima foi atribuição por cópia

            a++; //acrescentando uma unidade a váriavel, é a mesma coisa que a +1
            b--; // Operador de decremento b - 1
            Console.WriteLine($"{a}  {b}");

            // Apenas um exemplo mais complexo
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "William";
            dynamic d = c; // aqui temos uma atribuição por referência 
            d.nome = "Santos";
            Console.WriteLine(c.nome);// Aqui ele vai apontar para o nome santos, porque ele pegou a refência do objeto, que acima teve uma atribuição, eles estão compartilhando o mesmo espaço de memória
        }// Algo muito interessante para se aprofundar, a diferença de atribuição por valor e por referencia, por exemplo, por valor oque eu notei,é que a variavel recebe o valor de outra váriavel, logo a atriubuição só foi no valor, assim cada váriavel ela vai ocupar sua própria memória, cada uma no seu espaço;
        //Já atribuição por referência, elas mantém o mesmo espaço de memória, ou seja, o novo valor é referênciado no mesmo espaço de memória do valor antigo, isso pode por exemplo desencardia problemas em restauração de valores naquele objeto, mais é um bom conceito para deixar um software melhor otimizado. Dar para reutilizar uma memória já alocada, para referenciar outros valores no objeto, que coisa linda né!
    }
}
