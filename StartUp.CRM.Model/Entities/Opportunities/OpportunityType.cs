using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Opportunities
{
    public class OpportunityType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Opportunity> Opportunities { get; set; }
    }
}
