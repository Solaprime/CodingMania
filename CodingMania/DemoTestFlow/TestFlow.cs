using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.DemoTestFlow
{
    internal class TestFlow
    {
        public (int, string) DoSomething()
        {
            return (1, "All Hail Here");
        }

        public void  MethodHere()
        {
            var test = new TestFlow();
            var(fistVariable, secondVaraible) = test.DoSomething();
            Console.WriteLine(fistVariable);
            Console.WriteLine(secondVaraible);
        }
    }
}
