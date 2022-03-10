using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product :BaseEntity
    {
         //getters and setters are used to upadte and retrive value of a variable
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public String PictureUrl { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId {get; set;}
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }

    }
}