using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Leads
{
    public class LeadSource : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Lead> Lead { get; set; }
        public virtual ICollection<Opportunities.Opportunity> Opportunity { get; set; }
    }
}
