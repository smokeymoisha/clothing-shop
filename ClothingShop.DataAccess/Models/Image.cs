using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop.DataAccess.Models
{
    public class Image
    {
        public int Id { get; set; }
        public byte[] ImageData { get; set; }

        public Item Item { get; set; }
        public int ItemId { get; set; }
    }
}
