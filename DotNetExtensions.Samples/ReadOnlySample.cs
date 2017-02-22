using System;

namespace DotNetExtensions.Samples
{
    public sealed class ReadOnlySample : ISample
    {
        public void Run()
        {
            var readOnlyInt = 10.AsReadOnly();
            Console.WriteLine($"Just created readonly int with value {readOnlyInt}.");

            Console.WriteLine($"{nameof(readOnlyInt)} == 10 ? {readOnlyInt == 10}.");

            Console.WriteLine("Now using the readonly int inside loop as a number.");
            for (int i = 0; i < readOnlyInt; i++)
            {
                Console.WriteLine($"Counting --- {i}...");
            }
        }
    }
}
