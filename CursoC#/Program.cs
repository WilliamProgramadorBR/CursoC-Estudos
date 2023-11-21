using System;
using System.Collections.Generic;
using CursoC_.Fundamentos;
using CursoCSharp.Fundamentos;



namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Olá mundo", Comentários.Executar },
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}