using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            MargheritaBuilder margheritaBuilder = new MargheritaBuilder();
            margheritaBuilder.Reset();

            director.MakeMargherita(margheritaBuilder);
            var margherita = margheritaBuilder.GetResult();

            StudentPizzaBuilder studentBuilder = new StudentPizzaBuilder();
            studentBuilder.Reset();

            director.MakeStudentPizza(studentBuilder);
            var studentPizza = studentBuilder.GetResult();

            Console.ReadKey();
        }
    }
}
