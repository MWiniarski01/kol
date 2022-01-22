using System;
namespace WebStore.Model.DataModels
{
    public class Address
    {
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual StationaryStore StationaryStore { get; set; }
        public int StationaryStoreId { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}