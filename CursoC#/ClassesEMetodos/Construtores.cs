using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.ClassesEMetodos {
    internal class Construtores {
        class Carro { public string Modelo;
            public string Fabricante;
            public int Ano;
            //Não à conflito de nomes, pois os parametros começam com letras minusculas 
            public Carro(string modelo, string fabricante, int ano) {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }
            public Carro() { }
        }
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");
        }
    }
}
