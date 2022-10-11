using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//----Fazer um programa para ler 3 números inteiros. Em seguida, mostrar qual o 
//menor dentre os 3. Em caso de empate, mostrar apenas uma vez.----//

namespace Logica
{
    public class Ex3
    {
        public void Exercicio()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int num1, num2, num3, menor;

            Console.Write("Primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                menor = num1;
            }
            else if (num2 < num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;

            }

            Console.WriteLine("Menor = " + menor);


        }
    }
}
