using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//---- Fazer um programa para ler um número inteiro N (máximo =10) e uma matriz quadrada
// de ordem N contendo números inteiros. Após, mostre a diagonal principal e a
//quantidade de valores negativos da matriz.

namespace Logica
{
    public class Ex7
    {
        public void Exercicio()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, cont;
            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for(int i=0; i < N; i++)
            {
                for(int j=0; j < N; j++)
                {
                    Console.Write("Elemento [" + i + " , " + j + "]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());

                }
            }
            Console.Write("Diagonal principal: ");
            for(int i=0; i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            cont = 0;
            for(int i=0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("Quantidade de negativos = " + cont);
        }

        
    }
}
