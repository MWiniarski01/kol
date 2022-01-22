using System;
using System.Collections.Generic;

namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public virtual IList<Order> Orders { get; set; }
        public virtual Customer Customer { get; set; }
    }
}