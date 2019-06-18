using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Products
{
    public class ProductPriceListDetail   : BaseEntity
    {
        public decimal Price { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public System.Guid ProductId { get; set; }
        public System.Guid ProductPriceListId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductPriceList ProductPriceList { get; set; }
    }
}
