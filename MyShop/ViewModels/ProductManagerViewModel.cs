using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.ViewModels
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}