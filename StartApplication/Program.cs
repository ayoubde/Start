using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ayoub = new int[] { 1,2,3,4,5,6};
            for (int i = 0,j=ayoub.Length-1; i < j; i++,j--)
            {
                int c=ayoub[i];
                ayoub[i]=ayoub[j];
                ayoub[j] = c;
            }
             
            for (int i = 0; i < ayoub.Length; i++)
            {
                Console.WriteLine(ayoub[i]);
            }
        }
    }
}
