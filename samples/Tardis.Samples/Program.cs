using System;

namespace Tardis.Samples
{
    class Program
    {
        static void Main()
        {
            var example1Tests = new Example1Tests();

            example1Tests.T001();
            example1Tests.T002();

            var example2Tests = new Example2Tests();

            example2Tests.T001();

            Console.WriteLine("All tests completed with success.");
        }
    }
}
