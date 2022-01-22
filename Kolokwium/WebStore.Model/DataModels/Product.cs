using System;
using System.Collections.Generic;

namespace WebStore.Model.DataModels
{
    public class Product
    {
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public byte[] ImageBytes { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual IList<ProductStock> ProductStocks { get; set; }
        public virtual IList<OrderProduct> OrderProducts { get; set; }
        public float Weight { get; set; }
    }
}