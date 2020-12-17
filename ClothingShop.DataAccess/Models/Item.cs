using System;
using System.Collections.Generic;
using System.Text;
using ClothingShop.DataAccess.Enums;

namespace ClothingShop.DataAccess.Models
{
    public class Item
    {
        public Item()
        {
            Images = new List<Image>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Condition Condition { get; set; }
        public Size Size { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public List<Image> Images { get; set; }
    }
}
