namespace Flyweight
{
    class TreeType
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public string Texture { get; private set; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }

        public void Draw()
        {

        }
    }
}