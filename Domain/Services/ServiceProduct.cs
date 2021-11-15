using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
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

            var validateStockQuantity = product.ValidatePropertyInt(product.StockQuantity, "StockQuantity");


            if (validateName && validateValue && validateStockQuantity)
            {
                product.RegistrationDate = DateTime.Now;
                product.UpdateDate = DateTime.Now;
                product.State = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdadeProduct(Product product)
        {
            var validateName = product.ValidatePropertyString(product.Name, "Name");

            var validateValue = product.ValidatePropertyDecimal(product.Value, "Value");

            var validateStockQuantity = product.ValidatePropertyInt(product.StockQuantity, "StockQuantity");

            if (validateName && validateValue && validateStockQuantity)
            {
                product.UpdateDate = DateTime.Now;
                await _IProduct.Update(product);
            }
        }
    }
}
