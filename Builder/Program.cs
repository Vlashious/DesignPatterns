using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            MargheritaBuilder margheritaBuilder = new MargheritaBuilder();

            director.MakeMargherita(margheritaBuilder);
            var margherita = margheritaBuilder.GetResult();

            StudentPizzaBuilder studentBuilder = new StudentPizzaBuilder();
            director.MakeStudentPizza(studentBuilder);
            var studentPizza = studentBuilder.GetResult();
        }
    }
}
