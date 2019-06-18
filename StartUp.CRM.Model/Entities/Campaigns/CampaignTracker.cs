using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Campaigns
{
    public class CampaignTracker : BaseEntity
    {
        public System.Guid CampaignId { get; set; }

        public virtual Campaign Campaign { get; set; }
    }
}
