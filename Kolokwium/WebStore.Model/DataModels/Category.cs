using System;
using System.Collections.Generic;

namespace WebStore.Model.DataModels
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}