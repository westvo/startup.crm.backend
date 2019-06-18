using StartUp.CRM.Model.Entities.Opportunities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Products
{
    public class Product  : BaseEntity
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public string UnitSymbol { get; set; }
        public string Description { get; set; }
        public System.Guid TaxonId { get; set; }

        public virtual ICollection<OpportunityProduct> OpportunityProducts { get; set; }
        public virtual ICollection<ProductPriceListDetail> ProductPriceListDetails { get; set; }
    }
}
