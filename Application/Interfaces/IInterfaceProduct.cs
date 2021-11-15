using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IInterfaceProduct: IInterfaceGenericApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdadeProduct(Product product);
        Task<List<Product>> ListProductsOfUser(string userId);
    }
}
