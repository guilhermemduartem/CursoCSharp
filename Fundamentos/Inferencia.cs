using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {

    class Inferencia {

        public static void Executar() {

            var nome = "Guilherme";
            // nome = 123;
            Console.WriteLine(nome);                        // var = string 

            //int idade;
            var idade = 32;                                 // com var é obrigado a ja declarar a variavel 
            Console.WriteLine(idade);

             

            int a;                                          // ou     int a = 3;
            a = 3; 

            int b = 2;                                      // ou     int = b;
                                                            //          b = 2;

            Console.WriteLine(a + b);
        }
    }
}
