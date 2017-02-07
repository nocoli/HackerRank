using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTesterFile
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            
            long summer = 0;
            
            for (int i = 0; i < n; i++) {
                summer = summer + arr[i];
            }
            
            Console.WriteLine(summer);

        }
    }
}