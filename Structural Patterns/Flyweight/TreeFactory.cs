using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    class TreeFactory
    {
        private static List<TreeType> _treeTypes = new List<TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var treeType = _treeTypes.FirstOrDefault(type => type.Color == color &&
                                                    type.Name == name &&
                                                    type.Texture == texture);
            if (treeType != null)
            {
                return treeType;
            }
            else
            {
                var newTreeType = new TreeType(name, color, texture);
                _treeTypes.Add(newTreeType);
                return newTreeType;
            }
        }
    }
}