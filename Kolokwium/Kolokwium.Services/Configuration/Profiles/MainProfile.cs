using AutoMapper;
using Kolokwium.Model.DataModels;
using Kolokwium.ViewModels.VM;

namespace Kolokwium.Services.Configuration.Profiles
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<Book, BookVm>().ReverseMap();
            // CreateMap<AddOrUpdateProductVm, Product>();
            //AutoMapper maps
        }
    }
}
