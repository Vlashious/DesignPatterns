using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMethod a1 = new OddMethod();
            a1.TemplateMethod(10); // Prints nothing.
            a1.TemplateMethod(15); // This is an odd number.

            a1 = new EvenMethod();
            a1.TemplateMethod(10); // This is an even number.
            a1.TemplateMethod(15); // Prints nothing.
        }
    }
}
