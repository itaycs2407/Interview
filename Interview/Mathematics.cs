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
    }
    }
