using Application.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.OpenApp
{
    public class AppProduct : IInterfaceProduct
    {
        private readonly IProduct _IProduct;
        private readonly IServiceProduct _IServiceProduct;
        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }

        public async Task AddProduct(Product product)
        {
            await _IServiceProduct.AddProduct(product);
        }

        public async Task UpdadeProduct(Product product)
        {
            await _IServiceProduct.UpdadeProduct(product);
        }

        public async Task<List<Product>> ListProductsOfUser(string userId)
        {
            return await _IProduct.ListProductOfUser(userId);
        }

        public async Task Add(Product Entity)
        {
            await _IProduct.Add(Entity);
        }

        public async Task Delete(Product Entity)
        {
            await _IProduct.Delete(Entity);
        }

        public async Task<Product> GetEntityById(int Id)
        {
           return await _IProduct.GetEntityById(Id);
        }

        public async Task<List<Product>> List()
        {
            return await _IProduct.List();
        }

        public async Task Update(Product Entity)
        {
            await _IProduct.Update(Entity);
        }


    }
}
