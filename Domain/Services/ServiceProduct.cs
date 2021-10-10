using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public async Task AddProduct(Product product)
        {
            var validateName = product.ValidatePropertyString(product.Name, "Name");
            
            var validateValue = product.ValidatePropertyDecimal(product.Value, "Value");

            if (validateName && validateValue)
            {
                product.State = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdadeProduct(Product product)
        {
            var validateName = product.ValidatePropertyString(product.Name, "Name");

            var validateValue = product.ValidatePropertyDecimal(product.Value, "Value");

            if (validateName && validateValue)
            {
                await _IProduct.Update(product);
            }
        }
    }
}
