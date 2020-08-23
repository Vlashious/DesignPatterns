using System;

namespace Builder
{
    class Director
    {
        public void MakeMargherita(IPizzaBuilder builder)
        {
            builder.AddDough();
            builder.AddTomatoSauce();
            builder.AddMozarella();
        }

        public void MakeStudentPizza(IPizzaBuilder builder)
        {
            builder.AddDough();
            builder.AddKetchup();
            builder.AddMeat();
        }
    }
}