using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop.DataAccess.Models
{
    public class Category
    {
        public Category()
        {
            Items = new List<Item>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Item> Items { get; set; }
    }
}
