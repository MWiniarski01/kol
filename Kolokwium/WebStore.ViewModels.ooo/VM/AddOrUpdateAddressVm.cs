using System.ComponentModel.DataAnnotations;

namespace WebStore.ViewModels.VM
{
    public class AddOrUpdateAddressVm
    {
        public int? Id { get; set; }
        public int? ApartmentNumber { get; set; }
        [Required]
        public int BuildingNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        [RegularExpression(@"^\d\d-\d\d\d$", 
            ErrorMessage = "Nieprawidłowy format! 00-000")]
        public string ZipCode { get; set; }
    }
}