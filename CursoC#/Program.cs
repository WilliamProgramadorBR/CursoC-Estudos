﻿using System;
using System.Collections.Generic;
using CursoC_.Fundamentos;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;



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
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura DoWhile - Estruturas de controle", EstrututaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de controle", EstruturaForEach.Executar},
                {"Estrutura Break - Estruturas de controle", UsandoBreak.Executar},
                {"Estrutura CONTINUE - Estruturas de controle", UsandoContinue.Executar},
                // Classes e Métodos

                {"Membros - Classes e Metodos", Membros.Executar},


            }) {

            };
            central.SelecionarEExecutar();

        }
    }
}