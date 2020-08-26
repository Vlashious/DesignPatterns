using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new string[]
            {
                "hi",
                "how are you?",
                "what r u doinn"
            };

            var iterator1 = new Iterator(items);
            var iterator2 = new Iterator(items, true);

            foreach (var item in iterator1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in iterator2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
