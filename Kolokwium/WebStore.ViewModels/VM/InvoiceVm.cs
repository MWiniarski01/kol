using System;
using System.Collections.Generic;

namespace WebStore.ViewModels.VM
{
    public class InvoiceVm
    {
        public AddressVm BillingAddressVm { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderId { get; set; }
        public IList<ProductVm> Products { get; set; }
        public AddressVm ShippingAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public long TrackingNumber { get; set; }
    }
}