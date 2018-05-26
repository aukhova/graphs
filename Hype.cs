using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void rep(int[] A, int vertex, int length)
        {
            if (2 * vertex + 1 > length) return;
            int l = 0; int r = 0;
            if (2 * vertex + 1 == length)
            {
                l = r = vertex * 2 + 1;

            }
            else
            {
                l = vertex * 2 + 1;
                r = vertex * 2 + 2;
            }

            int imax = A[l] > A[r] ? l : r;
            if (A[imax] > A[vertex])
            {
                int tmp = A[imax];
                A[imax] = A[vertex];
                A[vertex] = tmp;
                rep(A, imax, length);
            }
            else
            {

            }
        }

        static void Main(string[] args)
        {
            int[] A = { 17, 2, 6, 21, 9, 1, 3, 5, 7, 8 };
            for (int i = A.Length / 2; i >= 0; i--)
            {
                rep(A, i, A.Length - 1);
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            for (int j = A.Length - 1; j > 0; j--)
            {
                int tmp = A[j];
                A[j] = A[0];
                A[0] = tmp;
                rep(A, 0, j - 1);
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
