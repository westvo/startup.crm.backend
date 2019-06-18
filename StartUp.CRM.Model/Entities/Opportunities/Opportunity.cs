using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.Model.Entities.Campaigns;
using StartUp.CRM.Model.Entities.Currencies;
using StartUp.CRM.Model.Entities.Leads;
using StartUp.CRM.Model.Entities.SalesUnits;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Opportunities
{
    public class Opportunity : BaseEntity
    {
        public string Name { get; set; }
        public int Status { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> FixedExchangeRate { get; set; }
        public string Description { get; set; }
        public double Ordinal { get; set; }
        public Nullable<int> Ranking { get; set; }
        public Nullable<System.Guid> OpportunityTypeId { get; set; }
        public Nullable<System.Guid> LeadSourceId { get; set; }
        public Nullable<System.Guid> LostReasonId { get; set; }
        public Nullable<System.Guid> CurrencyId { get; set; }
        public Nullable<System.Guid> CampaignId { get; set; }
        public Nullable<System.Guid> StageId { get; set; }
        public System.DateTime LastMovedDate { get; set; }
        public Nullable<System.Guid> PipelineId { get; set; }
        public System.DateTime CloseDate { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual LeadSource LeadSource { get; set; }
        public virtual LostReason LostReason { get; set; }
        public virtual ICollection<OpportunityAudit> OpportunityAudits { get; set; }
        public virtual ICollection<OpportunityProduct> OpportunityProducts { get; set; }
        public virtual OpportunityType OpportunityType { get; set; }
        public virtual Pipeline Pipeline { get; set; }
        public virtual Stage Stage { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        //public virtual ICollection<SalesUnit> SalesUnits { get; set; }
    }
}
