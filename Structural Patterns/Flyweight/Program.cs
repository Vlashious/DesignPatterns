namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var forest = new Forest();
            forest.PlantTree(100, 200, "Oak", "Dark", "OakTexture");
            forest.PlantTree(200, 200, "Oak", "Dark", "OakTexture");
            // The program still has 1 type of tree.

            forest.PlantTree(100, 150, "Birch", "Dark", "BirchTexture");
            // The program now has 2 types of tree.
        }
    }
}
