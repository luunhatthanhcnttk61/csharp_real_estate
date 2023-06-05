using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csharp_real_estate.Models
{
    public class ProductViewModels
    {
        public product product { get; set; }
        public string thumb { get; set; }
        public ProductViewModels()
        {
            // Empty Constructor
        }
        public ProductViewModels(product product, string thumb)
        {
            this.product = product;
            this.thumb = thumb;
        }
    }
}