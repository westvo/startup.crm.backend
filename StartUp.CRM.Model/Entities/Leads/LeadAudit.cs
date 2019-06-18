using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Leads
{
    public class LeadAudit : BaseEntity
    {
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public string BeforeValueString { get; set; }
        public string AfterValueString { get; set; }
        public Nullable<System.Guid> LeadId { get; set; }

        public virtual Lead Lead { get; set; }
    }
}
