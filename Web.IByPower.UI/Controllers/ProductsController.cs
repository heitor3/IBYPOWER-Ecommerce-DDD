using Application.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Web.IByPower.UI.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IInterfaceProduct _IInterfaceProduct;
        public ProductsController(IInterfaceProduct IInterfaceProduct)
        {
            _IInterfaceProduct = IInterfaceProduct;
        }

        // GET: ProductsController
        public async Task<IActionResult> Index()
        {

            return View(await _IInterfaceProduct.List());
        }

        // GET: ProductsController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await _IInterfaceProduct.GetEntityById(id));
        }

        // GET: ProductsController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            try
            {
                await _IInterfaceProduct.AddProduct(product);
                if (product.Notifications.Any())
                {
                    foreach (var item in product.Notifications)
                    {
                        ModelState.AddModelError(item.NameProperty, item.Message);
                    }

                    return View("Edit", product);
                }

            }
            catch
            {
                return View("Edit", product);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ProductsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            try
            {
                await _IInterfaceProduct.UpdadeProduct(product);
                if (product.Notifications.Any())
                {
                    foreach (var item in product.Notifications)
                    {
                        ModelState.AddModelError(item.NameProperty, item.Message);
                    }

                    return View("Edit", product);
                }

            }
            catch
            {
                return View("Edit", product);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ProductsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _IInterfaceProduct.GetEntityById(id));
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Product product)
        {
            try
            {
                var productDelete = await _IInterfaceProduct.GetEntityById(id);

                await _IInterfaceProduct.Delete(productDelete);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
