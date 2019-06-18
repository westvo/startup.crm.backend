using StartUp.CRM.Model.Entities.Leads;
using StartUp.CRM.Model.Entities.Opportunities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Campaigns
{
    public class Campaign : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<CampaignAudit> CampaignAudits { get; set; }
        public virtual ICollection<CampaignLog> CampaignLogs { get; set; }
        public virtual ICollection<CampaignTracker> CampaignTrackers { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
    }
}
