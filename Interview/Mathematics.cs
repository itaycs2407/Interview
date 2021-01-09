using System;



namespace Interview
{
    public static class Mathematics
    {
        // find and return the next squre number of the pervious root
        public static long findNextSqure(long  number)
        {
            if (Math.Sqrt(number) == Math.Floor(Math.Sqrt(number)))
            {
                return (long)Math.Pow((Math.Sqrt(number) + 1),2);
            }
            return -1;
        }

        /*
         Given a positive integer n, find the number of non-negative integers less than or equal to n, 
         whose binary representations do NOT contain consecutive ones. - FROM LEETCODE
         */
        public static int withoutConsecutiveOnes(int i_Num)
        {
            if (validator(i_Num))
            {
                return -1;
            }
            int counter = 0;
            for (int i = 0; i <= i_Num; i++)
            {
                string binarySTR = intAsBinary(i);
                if (noConsecutiveOnes(binarySTR))
                {
                    counter++;
                }
            }
            return counter;
           
        }

        private static bool noConsecutiveOnes(string binarySTR)
        {
            for (int i = 0; i < binarySTR.Length-1; i++)
            {
                if (binarySTR[i] =='1' && binarySTR[i+1] =='1')
                {
                    return false;
                }
            }

            return true;
        }

        private static string intAsBinary(int i_Num)
        {
            return Convert.ToString(i_Num, 2);
        }

        private static bool validator(int i_Num)
        {
            return (i_Num < 0);
        }
    }
    }
