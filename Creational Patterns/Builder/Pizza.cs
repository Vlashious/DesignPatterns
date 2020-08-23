using System.Collections.Generic;

namespace Builder
{
    class Pizza
    {
        private List<object> _attributes = new List<object>();
        public void AddAtribute(string attr)
        {
            _attributes.Add(attr);
        }
    }
}