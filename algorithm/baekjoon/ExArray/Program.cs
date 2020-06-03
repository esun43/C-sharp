using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            int[] arr = new int[26];
            S = Console.ReadLine();
            foreach (char c in S)
            {
                arr[c - 'a'] += 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
