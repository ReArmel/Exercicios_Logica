using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//--- Fazer um programa para ler as medidas da base e altura de um retângulo.
//Em seguida mostrar o valor da área, perímetro e Diagonal, com quatro casas decimais----//

namespace Logica
{
    public class Ex1
    {
        public void Exercicio()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, altura, area, perimetro, diagonal;
            Console.Write("Base do Retângulo: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Altura do Retângulo: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = largura * altura;
            perimetro = 2* (largura + altura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2.0) + Math.Pow(altura, 2.0));
            Console.WriteLine("ÁREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));

           
        }
    }
}
