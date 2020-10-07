using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Menu
{
    class Menu
    {
        public DateTime LastUpdated { get; }
        public List<MenuItem> Items { get; set; }

        public Menu(DateTime dateUpdated, List<MenuItem> item)
        {
            LastUpdated = dateUpdated;
            Items = item;
        }
    }
}
