using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.SalesUnits
{
    public class StageCheckedList : BaseEntity
    {
        public string Name { get; set; }
        public int ItemType { get; set; }
        public int Ordinal { get; set; }
        public System.Guid StageId { get; set; }
        public System.Guid StageCustomFieldId { get; set; }

        public virtual Stage Stage { get; set; }
        public virtual StageCustomField StageCustomField { get; set; }
    }
}
