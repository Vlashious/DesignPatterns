using System;

namespace Builder
{
    class MargheritaBuilder : IPizzaBuilder
    {
        private MargheritaBuilder _pizza;

        public void Reset()
        {
            _pizza = new MargheritaBuilder();
        }

        public void AddDough()
        {
            Console.WriteLine("Dough added.");
        }

        public void AddTomatoSauce()
        {
            Console.WriteLine("Tomato sauce added.");
        }

        public void AddMeat()
        {
            throw new NotImplementedException();
        }

        public void AddMozarella()
        {
            Console.WriteLine("Mozarella added.");
        }

        public void AddKetchup()
        {
            throw new NotImplementedException();
        }

        public MargheritaBuilder GetResult()
        {
            return _pizza;
        }
    }
}