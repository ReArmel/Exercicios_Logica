using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//--- Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar
// uma mensagem com os nomes e a idade média entre elas, com uma casa decimal ----//

namespace Logica
{
    public class Ex2
    {
        public void Exercicio()
        {
            CultureInfo CI = CultureInfo.InvariantCulture; 

            int idade1, idade2;
            string nome1, nome2;
            double media;

            Console.WriteLine("Dados da Primeira pessoa: ");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa: ");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2.0;
            Console.WriteLine("A Idade media da " + nome1 +  " e " + nome2 + " é de " + media.ToString("F1", CI) + " anos");



        }

    }
}
