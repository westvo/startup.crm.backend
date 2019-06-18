using StartUp.CRM.Model.Entities.Opportunities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.SalesUnits
{
    public class Stage : BaseEntity
    {
        public string Name { get; set; }
        public double Percentage { get; set; }
        public double TimeFrame { get; set; }
        public System.Guid PipelineId { get; set; }

        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual Pipeline Pipeline { get; set; }
        public virtual ICollection<StageCheckedList> StageCheckedLists { get; set; }
    }
}
