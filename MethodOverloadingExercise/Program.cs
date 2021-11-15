using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public int Add(int p1, int p2)
        {
            return p1 + p2;
        }
        public decimal Add (decimal d1, decimal d2)
        {
            return d1 + d2;
        }
        public string Add( int i1, int i2, bool b)
        {
            int sum = i1 + i2;
            if (b)
            {
                if (sum == 1)
                {
                    return sum.ToString() + "dollar";
                }
                else
                {
                    return sum.ToString() + "dollars";
                }
            }
            else
            {
                return sum.ToString();
                
            }
        }
    }
}
