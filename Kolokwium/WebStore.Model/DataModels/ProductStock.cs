using System;

namespace WebStore.Model.DataModels
{
    public class ProductStock
    {

        public int ProductStockId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}