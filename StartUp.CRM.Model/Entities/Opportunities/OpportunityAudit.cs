using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Opportunities
{
    public class OpportunityAudit : BaseEntity
    {
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public string BeforeValueString { get; set; }
        public string AfterValueString { get; set; }
        public System.Guid OpportunityId { get; set; }

        public virtual Opportunity Opportunity { get; set; }
    }
}
