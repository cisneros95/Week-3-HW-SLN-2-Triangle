using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_HW_SLN_2_Triangle
{
    class Program
    {

        // Function to  calculate for validity
        public static int checkValidity(int a, int b, int c)

        {

            // check condition
            if (a + b <= c || a + c <= b || b + c <= a)
                return 0;
            else
                return 1;

        
        
        }

        //Driver Code
        static void Main()
        {
            int a = 7, b = 10, c = 5;

            // function calling and print out
            if ((checkValidity(a, b, c)) == 1)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            

        }
    }
}
