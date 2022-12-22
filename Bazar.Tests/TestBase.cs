using AutoMapper;
using Bazar.Data.Repositories;
using Bazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Tests
{
    public class TestBase
    {
        protected IMapper CreateMapper()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
            return mockMapper.CreateMapper();
        }

        protected ClaimsIdentity CreateIdentity()
        {
            var identity = new ClaimsIdentity();
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, "123"));
            return identity;
        }

        protected Services CreateServices()
        {
            var mapper = CreateMapper();
            return new Services
            {
                Mapper = mapper,
                CategoryRepository = new CategoryFakeRepository(mapper),
                ItemRepository = new ItemFakeRepository(mapper),
            };
        }

        protected class Services
        {
            public IItemRepository ItemRepository { get; set; }
            public ICategoryRepository CategoryRepository { get; set; }
            public IMapper Mapper { get; set; }
        }
    }
}
