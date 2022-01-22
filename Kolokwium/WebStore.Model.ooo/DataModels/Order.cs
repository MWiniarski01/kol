using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
        public DateTime DeliveryDate  { get; set; }
        public DateTime OrderDate { get; set; }
        [NotMapped]
        public decimal TotalAmount { get; }
        public long TrackingNumber  { get; set; }
        public virtual IList<OrderProduct> OrderProducts { get; set; }
    }
}