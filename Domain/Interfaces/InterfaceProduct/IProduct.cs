using Domain.Interfaces.Generics;
using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceProduct
{
    public interface IProduct : IGeneric<Product>
    {
        Task<List<Product>> ListProductOfUser(string userId);
    }
}
