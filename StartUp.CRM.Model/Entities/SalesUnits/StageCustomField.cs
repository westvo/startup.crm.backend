using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.SalesUnits
{
    public class StageCustomField : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<StageCheckedList> StageCheckedLists { get; set; }
    }
}
