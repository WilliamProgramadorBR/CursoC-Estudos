﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.ClassesEMetodos {
     class Params {
        public static void Recepcionar(params string[] pessoas) { 
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Olá {0}", pessoa);
                Console.WriteLine("Olá Adryel");
            }
        }
        public static void Executar() { Recepcionar("Pedro", "Manu", "Roger"); }
        
    }
}
