using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;

//----Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida
//1) Imprimir todos os elementos do vetor
//2) Mostrar na tela a soma e a média dos elementos do vetor

namespace Logica
{
    public class Ex6
    {
        public void Exercicio()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N;
            double soma, media;

            Console.WriteLine("Quantos números você vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] array = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                array[i] = double.Parse(Console.ReadLine(),CI);
            }

            Console.WriteLine();
            Console.Write("Valores = ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i].ToString("F1", CI) + " ");
            }

            Console.WriteLine();

            soma = 0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + array[i];
            }
            Console.WriteLine("SOMA = " + soma.ToString("F2", CI));

            media = soma / N;
            Console.WriteLine("MÉDIA= " + media.ToString("F2", CI));
            
        }
    }
}
