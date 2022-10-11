using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//---- Leia uma quantidade indeterminada de duplas de valores inteiros X e Y.
//Escreva para cada X e Y uma mensagem que indique se esses valores foram digitados
//em ordem crescente ou decrescente. Finalize o programa quando dois números 
//iguais forem digitados.----//

namespace Logica
{
    public class Ex4
    {
        public void Exercicio()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y;
            Console.WriteLine("Digite dois números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while( x != y)
            {
                if( x < y)
                {
                    Console.WriteLine("Ordem crescente!");
                }
                else
                {
                    Console.WriteLine("Ordem decrescente!");
                }

                Console.WriteLine("Digite outros dois números: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }

        }
    }
}
