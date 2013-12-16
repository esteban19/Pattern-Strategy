using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new instance of class that "owns a" IStrategy interface.
            Context ctx;

            ctx = new Context(new Add());
            int result1 = ctx.runIStrategy(5, 4);

            ctx = new Context(new Subtract());
            int result2 = ctx.runIStrategy(5, 4);

            ctx = new Context(new Multiply());
            int result3 = ctx.runIStrategy(5, 4);

            Console.WriteLine("result 1 = {0}", result1);
            Console.WriteLine("result 2 = {0}", result2);
            Console.WriteLine("result 3 = {0}", result3);
        }
    }
}
