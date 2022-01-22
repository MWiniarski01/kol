using System;
using System.Collections.Generic;

namespace WebStore.Model.DataModels
{
    public class Supplier : User
    {
        public int SupplierId { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}