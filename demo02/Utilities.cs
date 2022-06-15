using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02 {
    /// <summary>
    /// Some utilities to calculate stuff
    /// </summary>
    public class Utilities {
        //Create a method called Greatest().
        //This method has 2 parameters with type int 
        //and returns the highest parameter.

        /// <summary>
        /// Returns the highest number
        /// </summary>
        /// <param name="a">The first number to compare</param>
        /// <param name="b">The second number to compare</param>
        /// <returns>The highest number</returns>
        public static int Greatest(int a, int b) => a > b ? a : b;

        public static string Greatest(string a, string b) => a.Length > b.Length ? a : b;

        public static void Swap(ref int parameter1, ref int parameter2) {
            int temp = parameter1;
            parameter1 = parameter2;
            parameter2 = temp;
        }

        //public static long Factorial(int n) {
        //    if (n == 1)
        //        return 1;
        //    else 
        //        return n * Factorial(n-1);
        //}

        public static long Factorial(int n) => (n == 1) ? 1 : n * Factorial(n - 1);
    }
}
