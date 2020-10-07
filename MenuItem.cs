using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        string name { get; set; }
        string item { get; set; }
        string description { get; set; }
        string category { get; set; }
        double price { get; set; }
        string age { get; set; }

        public MenuItem(string Name, string Item, string Description, string Category, double Price, string Age)
        {
            name = Name;
            item = Item;
            description = Description;
            category = Category;
            price = Price;
            age = Age;
        }
    }
}
