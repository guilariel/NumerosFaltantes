using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosFaltantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
            
            FindDisappearedNumbers(nums);
        }

        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            HashSet<int> ints = new HashSet<int>(nums);
            List<int> numeros = new List<int>();

            for (int i = 1; i <= nums.Length; i++)
            {
                if (ints.Contains(i))
                {
                    continue;
                }
                numeros.Add(i);
            }

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            return numeros;
        }
    }
}
