using System;


namespace Recursion
{
    internal class DecimalToBinary
    {

        public int Run(int num)
        {
            int bin = Base10_2_Binary(num);
            System.Console.WriteLine(bin);
            return bin;
        }
        private int Base10_2_Binary(int num)
        {
            int bin;

            if (num == 0)                         // stop condition 
                return 0;

            var v = Base10_2_Binary(num / 2);// frame stack

            bin = (num % 2) + 10 * v;

            return (bin);
        }

    }
}
