﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.ClassesEMetodos {
    internal class Pessoa {
        public string Nome;
        public int Idade;


        public string Apresentar() {
            return string.Format($"Olá me chamo{Nome} e tenho {Idade} anos. Sou muito feliz!");
        }
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

    }
}
