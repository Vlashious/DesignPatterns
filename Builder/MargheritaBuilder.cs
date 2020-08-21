using System;

namespace Builder
{
    class MargheritaBuilder : IPizzaBuilder
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
            Console.WriteLine("Tomato sauce added.");
            _pizza.AddAtribute("Tomato sauce");
        }

        public void AddMeat()
        {
            throw new NotImplementedException();
        }

        public void AddMozarella()
        {
            Console.WriteLine("Mozarella added.");
            _pizza.AddAtribute("Mozarella");
        }

        public void AddKetchup()
        {
            throw new NotImplementedException();
        }

        public Pizza GetResult()
        {
            return _pizza;
        }
    }
}