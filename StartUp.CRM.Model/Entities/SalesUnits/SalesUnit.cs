using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.Model.Entities.Leads;
using StartUp.CRM.Model.Entities.Opportunities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.SalesUnits
{
    public class SalesUnit : BaseEntity
    {
        public string Name { get; set; }
        public Nullable<System.Guid> ParentId { get; set; }
        public System.Guid RoleId { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<Pipeline> Pipelines { get; set; }
    }
}
