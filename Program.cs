using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {

    class Program {

        static void Main(string[] args) {

            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", Interpolacao.Executar }, 
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar }, 
                {"LendoDados - Fundamentos", LendoDados.Executar }, 




            });

            central.SelecionarEExecutar();
        }
    }
}