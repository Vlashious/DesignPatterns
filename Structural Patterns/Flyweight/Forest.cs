using System.Collections.Generic;

namespace Flyweight
{
    class Forest
    {
        public List<Tree> Trees { get; private set; } = new List<Tree>();

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            var type = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(x, y, type);
            Trees.Add(tree);
        }

        public void Draw()
        {
            foreach (var tree in Trees)
            {
                tree.Draw();
            }
        }
    }
}