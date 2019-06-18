using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Campaigns
{
    public class CampaignAudit : BaseEntity
    {
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public string BeforeValueString { get; set; }
        public string AfterValueString { get; set; }
        public System.Guid CampaignId { get; set; }

        public virtual Campaign Campaign { get; set; }
    }
}
