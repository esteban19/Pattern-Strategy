using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Context
    {
        //Create a new instance of IStrategy that can "point" to a decoupled method.
        private IStrategy istrat;

        public Context(IStrategy istrat)
        {
            //ctx        //from constructor
            this.istrat = istrat;
        }

        public int runIStrategy(int a, int b)
        {
            //istrat(client) "realizes" behavior the +,-,*(supplier) specifies. 
            return this.istrat.arithmetic(a, b);
        }
    }
}
