using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {                                   // .ToUpper =ira trocar as letras minusculas por maiusculas 
    class NotacaoPonto {                                              // entao o "olá" vai virar "OLÁ" 
                                                                      //
        public static void Executar () {                              // .Insert(3, " World!") = irar inserir na posição 3,q ira contar a partir
                                                                      //"O"= 0     "L"=1    "Á"=2    O 3 seria o proximo espaço e sera usado para 
            var saudacao = "olá".ToUpper().Insert(3, " World!")        //para colocar o " World!" (ja com o espaço!).
                                   .Replace("World", "Mundo!");       //
            Console.WriteLine(saudacao);                              // .Replace("World", "Mundo!"); = ele irar trocar o "World" por "Mundo!".  
                                                                      //
            Console.WriteLine("teste".Length);                        //.Length = ele irar conta quantas letras tem ("teste".Length); = vai  aparecer o numero 5
                                                                      //que é o numero de letra que tem em "teste".
            string valorImportante = null;                            // 
            Console.WriteLine(valorImportante?.Length);               // null é para declarar algo sem valor 
                                                                      //
                                                                      // (valorImportante?.Length); = como ? é para ter um navegação segura.
                                                                      //
                                                                      //.ToUpper()   como tiver () é pq é um metodo 
        }
    }
}
