using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Product>, IProduct
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilder;
        public RepositoryProduct()
        {
            _optionsBuilder = new DbContextOptions<ContextBase>();
        }
        public async Task<List<Product>> ListProductOfUser(string userId)
        {
            using (var database = new ContextBase(_optionsBuilder))
            {
                return await database.Product.Where(p => p.UserId == userId)
                    .AsNoTracking()
                    .ToListAsync();
            }
        }
    }
}
