using System;

namespace Builder
{
    class StudentPizzaBuilder : IPizzaBuilder
    {
        private StudentPizzaBuilder _pizza;

        public void Reset()
        {
            _pizza = new StudentPizzaBuilder();
        }

        public void AddDough()
        {
            Console.WriteLine("Dough added.");
        }

        public void AddTomatoSauce()
        {
            throw new NotImplementedException();
        }

        public void AddMeat()
        {
            Console.WriteLine("Meat added.");
        }

        public void AddMozarella()
        {
            throw new NotImplementedException();
        }

        public void AddKetchup()
        {
            Console.WriteLine("Ketchup added.");
        }

        public StudentPizzaBuilder GetResult()
        {
            return _pizza;
        }
    }
}