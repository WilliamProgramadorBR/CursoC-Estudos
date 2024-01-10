using System;
using System.Collections.Generic;
using CursoC_.Fundamentos;
using CursoCSharp.Fundamentos;



using CursoC_.EstruturaDeControle;
namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Olá mundo", Comentários.Executar },
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação  - Fundamentos", Interpolacao.Executar},
                {"Notação ponto  - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados no console  - Fundamentos", LendoDados.Executar},
                {"Formantnado Número  - Fundamentos", FormatandoNumero.Executar},
                {"Conversões  - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos  - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - fundamentos", OperadoresLogicos.Executar},
                {"Operadores de atribuições - fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - fundamentos", OperadoresUnarios.Executar},
                {"Operadore Ternário - fundamentos", OperadorTernario.Executar},
                // Agora vamos falar de estruturas de controle
                {"Estrutura If - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura If e Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar},


            }); central.SelecionarEExecutar();

        }
    }
}