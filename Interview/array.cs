using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class array
    {
        public static void Run()
        {
            int[,] mat = new int[,]  { {1,2,3 },{4,5,6 },{7,8,9 } };
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            printMat(mat);
            Console.WriteLine();
            rotateMat(ref mat);
            Console.WriteLine();
            printMat(mat);
            Console.WriteLine();
            printArr(arr);
            rotateArrForward(ref arr);
            printArr(arr);

        }

        private static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        private static void rotateArrForward(ref int[] arr)
        {
            int hor = arr.GetLength(0);
            int nextVal, prevVal = arr[0];
            for (int i = 1; i < hor; i++)
            {
                nextVal = arr[i];
                arr[i] = prevVal;
                prevVal = nextVal;
            }
            arr[0] = prevVal;
            Console.WriteLine();
        }

        private static void rotateMat(ref int[,] mat)
        {
            int n = mat.GetLength(0);
            for (int layer = 0; layer < n/2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = mat[first, i];
                    mat[first, i] = mat[last - offset, first];
                    mat[last - offset, first] = mat[last, last - offset];
                    mat[last, last - offset] = mat[i, last];
                    mat[i, last] = top;
                }
            }
        }

        private static void printMat(int [,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
