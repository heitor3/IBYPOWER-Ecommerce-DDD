using Entities.Entities;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IInterfaceProduct: IInterfaceGenericApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdadeProduct(Product product);
    }
}
