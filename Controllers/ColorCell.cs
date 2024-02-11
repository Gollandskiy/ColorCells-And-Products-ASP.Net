using System.Collections.Generic;
using Product_ASP.Net.Models;

namespace Product_ASP.Net.Models
{
    public class ColorCell
    {
        public string Value { get; set; }
        public string Color { get; set; }

        public List<List<ColorCell>> GetColoredTable(List<ProductClass> products)
        {
            var coloredTable = new List<List<ColorCell>>();

            foreach (var product in products)
            {
                var row = new List<ColorCell>
                {
                    new ColorCell { Value = product.NameTovar },
                    new ColorCell { Value = product.Count.ToString() },
                    new ColorCell { Value = product.PriceForOne.ToString(), Color = GetPriceColor(product.PriceForOne) },
                    new ColorCell { Value = product.AllPrice.ToString(), Color = GetPriceColor(product.AllPrice)  }
                };
                coloredTable.Add(row);
            }

            return coloredTable;
        }

        private string GetPriceColor(int price)
        {
            if (price < 50)
                return "green";
            else if (price < 100)
                return "yellow";
            else
                return "red";
        }
    }
}