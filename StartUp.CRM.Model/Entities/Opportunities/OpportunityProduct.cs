using StartUp.CRM.Model.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Opportunities
{
    public class OpportunityProduct : BaseEntity
    {
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public System.Guid OpportunityId { get; set; }
        public System.Guid ProductId { get; set; }

        public virtual Opportunity Opportunity { get; set; }
        public virtual Product Product { get; set; }
    }
}
