using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrinceLabz.AspNetCoreCookies.Auth.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
    }
}
