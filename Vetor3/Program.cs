using System;
using System.Globalization;

namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            int[] A;
            int[] B;
            int[] C;
            N = int.Parse(Console.ReadLine());
            A = new int[N];
            B = new int[N];
            C = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(s[i]);
            }

            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(s[i]);
            }
           
            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
            }
            for (int i =0; i < N; i++)
            {

               
                Console.WriteLine(C[i] + " ");
            }
            Console.WriteLine();
        }
    }
}