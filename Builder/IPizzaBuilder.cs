namespace Builder
{
    interface IPizzaBuilder
    {
        public void Reset();
        public void AddDough();
        public void AddTomatoSauce();
        public void AddMeat();
        public void AddMozarella();
        public void AddKetchup();
    }
}