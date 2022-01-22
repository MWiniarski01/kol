using AutoMapper;
using WebStore.Model.DataModels;
using WebStore.ViewModels.VM;

namespace WebStore.Services.Configuration.Profiles
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            //AutoMapper maps
            CreateMap<Product, ProductVm>()
                .ReverseMap();
            CreateMap<AddOrUpdateProductVm, Product>();
            // Custom
            CreateMap<Invoice, InvoiceVm>()
                .ReverseMap();
            CreateMap<Address, AddressVm>()
                .ReverseMap();
            CreateMap<AddOrUpdateAddressVm, Product>();
        }
    }
}