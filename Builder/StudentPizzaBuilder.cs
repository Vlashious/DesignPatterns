using System;

namespace Builder
{
    class StudentPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza;

        public void Reset()
        {
            _pizza = new Pizza();
        }

        public void AddDough()
        {
            Console.WriteLine("Dough added.");
            _pizza.AddAtribute("Dough");
        }

        public void AddTomatoSauce()
        {
            throw new NotImplementedException();
        }

        public void AddMeat()
        {
            Console.WriteLine("Meat added.");
            _pizza.AddAtribute("Meat");
        }

        public void AddMozarella()
        {
            throw new NotImplementedException();
        }

        public void AddKetchup()
        {
            Console.WriteLine("Ketchup added.");
            _pizza.AddAtribute("Ketchup");
        }

        public Pizza GetResult()
        {
            return _pizza;
        }
    }
}