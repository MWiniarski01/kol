using System;
using System.Collections.Generic;

namespace WebStore.Model.DataModels
{
    public class Customer : User
    {
        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}