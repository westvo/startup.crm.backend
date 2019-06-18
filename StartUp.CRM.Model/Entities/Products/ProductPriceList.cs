using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Products
{
    public class ProductPriceList    : BaseEntity
    {
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }

        public virtual ICollection<ProductPriceListDetail> ProductPriceListDetails { get; set; }
    }
}
