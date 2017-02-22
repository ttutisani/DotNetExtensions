using System;
using System.Linq;
using DotNetExtensions;

namespace DotNetExtensions.Samples
{
    class Program
    {
        private static readonly ISample[] _samples = new ISample[]
        {
            new ReadOnlySample()
        };

        static void Main(string[] args)
        {
            while (HandleNextCommand()) ;
        }

        private static bool HandleNextCommand()
        {
            Console.WriteLine("Supported samples:");
            Console.WriteLine(string.Join(", ", _samples.Select((sample, i) => $"{i}: {sample.GetType().Name}")));
            Console.WriteLine("Enter sample number to run:");

            var index = Console.ReadLine().ToInt(-1);
            if (index >= 0 && index < _samples.Length)
            {
                _samples[index].Run();
                Console.WriteLine("========================");
            }

            return true;
        }
    }
}
