using System;
using System.Text;

namespace Interview
{
    public static class StringQuestion
    {
        public static string stringCompression(string i_Str) // convert string from aaabbffffe --> a3b2f4e1
        {
            if (i_Str.Length == 0)
            {
                return null;
            }
            StringBuilder result = new StringBuilder();
            char currentChar = i_Str[0];
            int counter = 1;
            for (int i = 1; i < i_Str.Length; i++)
            {
                if (i_Str[i] == currentChar)
                {
                    counter++;
                }
                else
                {
                    result.Append(currentChar);
                    result.Append(counter);
                    currentChar = i_Str[i];
                    counter = 1;
                }
            }
            result.Append(currentChar);
            result.Append(counter);

            return result.ToString();
        }
        public static bool isPolyndromPermutation(string i_Str)
        {
            int[] counterArr = new int[26];
            if (i_Str.Length < 2) // 0 or 1 length==> is polyndrom
            {
                return true;
            }

            for (int i = 0; i < i_Str.Length; i++) // count each char appearance in the string to counter array
            {
                if (i_Str[i] != ' ') // dont count space
                {
                    counterArr[Char.ToLower(i_Str[i]) - 97]++;
                }
            }

            int hasOne = 0;
            bool result = true;
            for (int i = 0; i < 26 && result; i++)
            {
                if (counterArr[i] % 2 != 0) // if the char appearance counter is odd
                {
                    if (counterArr[i] % 2 == 1) // one single appearance of char in polyndrom is allowed
                    {
                        if (hasOne == 1)  // check that it is the only char with one appearance
                        {
                            result = false; // has more than one appearance
                        }
                        hasOne++;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }

            return result;
        }
        public static bool oneAway(string i_S1, string i_S2)
        {
            if (i_S1.Equals(i_S2))
            {
                return true;
            }
            if (i_S1.Length == i_S2.Length)
            {
                return oneEditCheck(i_S1, i_S2);
            }
            else if ((i_S1.Length + 1 == i_S2.Length) || (i_S1.Length - 1 == i_S2.Length))
            {
                return oneInsertionCheck(i_S1, i_S2);
            }
            return false;

        }

        private static bool oneInsertionCheck(string i_S1, string i_S2)
        {
            string s1 = i_S1.Length > i_S2.Length ? i_S1 : i_S2;
            string s2 = i_S1.Length > i_S2.Length ? i_S2 : i_S1;
            int add = 0;
            for (int i = 0; i < i_S2.Length; i++)
            {
                if (s2[i] != s1[i + add])
                {
                    if (add == 1)
                    {
                        return false;
                    }
                    add++;
                    i--;
                }
            }
            return true;
        }

        private static bool oneEditCheck(string i_S1, string i_S2)
        {
            for (int i = 0; i < i_S1.Length; i++)
            {
                bool foundDifference = false;
                if (i_S1[i] != i_S2[i]) // found difference
                {
                    if (foundDifference) // already found one diff ==> this is the second diff
                    {
                        return false;
                    }

                    foundDifference = true; // record the first diff
                }
            }
            return true;
        }
    }
}
    
