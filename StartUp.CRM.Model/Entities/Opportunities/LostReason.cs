using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Opportunities
{
    public class LostReason : BaseEntity
    {
        public string Reason { get; set; }

        public virtual ICollection<Opportunity> Opportunity { get; set; }
    }
}
