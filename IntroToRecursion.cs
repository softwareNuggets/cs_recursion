using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class IntroToRecursion
    {
        public Stack<int> steps = new Stack<int>();

        public void ShowExample()
        {
            int i = 3;
            Show(i);
        }

        private void Show(int num)
        {

            if (num > 0)                 // stop condition 
            {
                steps.Push(num);        // push num to stack object steps

                Show(num - 1);          // recursion ... decrement num by 1

                Console.WriteLine(steps.Pop()); //stop condition reached, pop the stack object
            }
        }
    }
}
