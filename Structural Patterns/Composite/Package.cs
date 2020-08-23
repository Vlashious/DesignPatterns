using System.Collections.Generic;

namespace Composite
{
    class Package : IComposite
    {
        private List<IComposite> _children = new List<IComposite>();

        public float GetPrice()
        {
            float price = 0;
            foreach (var child in _children)
            {
                price += child.GetPrice();
            }
            return price;
        }

        public void AddItem(IComposite item)
        {
            _children.Add(item);
        }

        public void RemoveItem(IComposite item)
        {
            _children.Remove(item);
        }
    }
}