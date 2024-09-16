using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
            Nascimento = new DateTime(1992, 03, 03);

        }

        public string GetDataNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    internal class Readonly {
        public static void Executar() {



        }
    }
}


//A palavra reservada "readonly", ela faz que a variavel funcione um pouco parecida com uma const, porém tem alguns diferenças importantes. Primeiro, ela permite modificação no valor inicial, porém dentro de um constrututor, diferente das const, uma vez definida não pode ser reatribuidas. 


