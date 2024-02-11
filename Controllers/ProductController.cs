using Microsoft.AspNetCore.Mvc;
using Product_ASP.Net.Models;

namespace Product_ASP.Net.Controllers
{
    public class ProductController : Controller
    {
        private List<ProductClass> products = new List<ProductClass>
        {
            new ProductClass { NameTovar = "Сникерс", Count = 10, PriceForOne = 15, AllPrice = 150 },
            new ProductClass { NameTovar = "Консервы", Count = 5, PriceForOne = 70, AllPrice = 350 },
            new ProductClass { NameTovar = "Рево", Count = 8, PriceForOne = 40, AllPrice = 320 }
        };

        public IActionResult ProductSite()
        {
            var colorCellModel = new ColorCell();
            var coloredTable = colorCellModel.GetColoredTable(products);
            return View(coloredTable);
        }
    }
}
