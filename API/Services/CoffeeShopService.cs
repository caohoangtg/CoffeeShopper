using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class CoffeeShopService : ICoffeeShopService
    {
        private readonly ApplicationDbContext _dbContext;

        public CoffeeShopService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CoffeeShopModel>> List()
        {
            var coffeeShops = await (from shop in _dbContext.CoffeeShops
                                    select new CoffeeShopModel()
                                    {
                                        Id = shop.Id,
                                        Name = shop.Name,
                                        Address = shop.Address,
                                        OpeningHours = shop.OpeningHours,
                                    }).ToListAsync();

            return coffeeShops;
        }
    }
}
