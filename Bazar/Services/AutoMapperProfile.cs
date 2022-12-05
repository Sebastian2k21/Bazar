using AutoMapper;
using Bazar.Data.Models;
using Bazar.DTO.Category;
using Bazar.DTO.Item;
using Bazar.Models;

namespace Bazar.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ItemViewModel, Item>();
            CreateMap<Item, ItemViewModel>();
            CreateMap<Item, ItemDetailsViewModel>()
                .ForMember(x => x.CategoryName, y => y.MapFrom(x => x.Category.Name))
                .ForMember(x => x.OwnerId, y => y.MapFrom(x => x.User.Id))
                .ForMember(x => x.OwnerName, y => y.MapFrom(x => x.User.UserName));
            CreateMap<Item, ItemGetDTO>();

            CreateMap<RegisterViewModel, User>();
            CreateMap<OrderViewModel, Order>();
            CreateMap<Order, OrderDetailsViewModel>()
                .ForMember(x => x.DeliveryMethodName, y => y.MapFrom(x => x.DeliveryMethod.Name))
                .ForMember(x => x.PaymentMethodName, y => y.MapFrom(x => x.PaymentMethod.Name))
                .ForMember(x => x.ItemId, y => y.MapFrom(x => x.Item.Id))
                .ForMember(x => x.ItemName, y => y.MapFrom(x => x.Item.Name));

            CreateMap<Category, CategoryGetDTO>();
            CreateMap<CategoryCreateDTO, Category>();

        }
    }
}
