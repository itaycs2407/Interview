using System;

namespace Interview
{
        public class array1
        {
            public static void Run()
            {
                int[,] mat = new int[,]  { {1,1,1,1,1,1},
                                           {1,1,0,1,1,1},
                                           {0,1,1,1,1,1},
                                           {1,1,1,1,0,1},
                                           {1,1,1,1,1,1},
                                           {1,1,1,0,1,1}};
              
                printMat(mat);
                bool[] row = new bool[6];
                bool[] col = new bool[6];
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (mat[i, j] == 0)
                        {
                            row[i] = col[j] = true;
                        }
                    }
                }
                
                // col
                for (int i = 0; i < 6; i++)
                {
                    if (col[i]) zeroMatCol(i, ref mat);
                    if (row[i]) zeroMatRow(i, ref mat);
                }

                printMat(mat);
            }

            private static void zeroMatCol(int i, ref int[,] mat)
            {
                for (int m = 0; m < 6; m++)
                {
                    mat[m, i] = 0;
                }
            }
            private static void zeroMatRow(int i, ref int[,] mat)
            {
                for (int m = 0; m < 6; m++)
                {
                    mat[i,m] = 0;
                }
            }
            private static void printMat(int[,] mat)
            {
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        Console.Write($"{mat[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
}
    
