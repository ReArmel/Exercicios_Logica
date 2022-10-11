using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//---- Leia 2 valores inteiros X e Y (em qualquer ordem).
// Em seguida calcule e mostre a soma dos números ímpares entre eles----//

namespace Logica
{
    public class Ex5
    {
        public void Exercicio()
        {
            int x, y, troca, soma;

            Console.WriteLine("Digite dois números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());  

            if (x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }
            soma = 0;
            for (int i = x+1 ; i < y; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine("SOMA DOS ÍMPARES = " + soma);
            

        }
    }
}
