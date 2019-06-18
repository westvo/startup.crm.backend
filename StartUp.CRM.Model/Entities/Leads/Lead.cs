using StartUp.CRM.Model.Entities.Campaigns;
using StartUp.CRM.Model.Entities.SalesUnits;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Leads
{
    public class Lead : BaseEntity
    {
        public int Status { get; set; }
        public Nullable<int> Ranking { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> LeadSourceId { get; set; }
        public Nullable<System.Guid> CampaignId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Gender { get; set; }
        public string CompanyName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCountry { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public string Website { get; set; }
        public string Position { get; set; }
        public string SocialLinks { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual ICollection<LeadAudit> LeadAudits { get; set; }
        public virtual LeadSource LeadSource { get; set; }
        //public virtual ICollection<SalesUnit> SalesUnits { get; set; }
    }
}
