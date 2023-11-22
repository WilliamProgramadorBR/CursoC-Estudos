using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
    class Inferencia {
        public static void Executar (){
            var nome = "William";// O C# pode identificar o tipo de dados colocado na variável e substituir o var pela tipagem correta da mesma
            var idade = 23; // Exemplo dois. Depois que o C# define um valor para a variavel, ela não pode ser trocada para outro tipo de entrada de dados, por exemplo, se criou uma var nome = "Olá mundo", você não pode por exemplo chamar o nome = 123; O C# já entende que a variavel nome é tipo String logo, somente estes tipos de dados podem entrar nela.
            // Ou seja, pode até atribuir outros valores a ela, desde o momento que seja do tipo que ela foi tipado, exemplo abaixo
             idade= 25;
            nome = "William Oliveira";
            Console.WriteLine("Após novos conhecimentos a idade do sujeito "+nome+ "Foi atualizada com sucesso "+idade);
        }
    }
}
