using AutoMapper;
using Bazar.Data.Models;
using Bazar.Models;

namespace Bazar.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ItemViewModel, Item>();
            CreateMap<Item, ItemDetailsViewModel>()
                .ForMember(x => x.CategoryName, y => y.MapFrom(x => x.Category.Name))
                .ForMember(x => x.OwnerId, y => y.MapFrom(x => x.User.Id))
                .ForMember(x => x.OwnerName, y => y.MapFrom(x => x.User.UserName));
            CreateMap<RegisterViewModel, User>();
        }
    }
}
