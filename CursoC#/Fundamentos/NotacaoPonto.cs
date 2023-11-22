using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper()/*Aqui toUpper, como no js, ele pode fazer uma string em minúsculo ficar maiúscula
                                           * */.Insert(3, " World!").Replace("World", "Mundo!");//Replace, como já visto no js, ele pega a posição de uma string e substitui pela string informada, logo ele trabalha com dois tipo argumentos
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // ATENÇÃO!!! como já sabemos, valores vazios pode causar erros em algumas áreas da sua aplicação, logo o C# tem uma forma de verificar se contém valor na váriavel apenas usando '?'

        }

    }
}
