using StartUp.CRM.Model.Entities.Opportunities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.SalesUnits
{
    public class Pipeline : BaseEntity
    {
        public string Name { get; set; }
        public string UrlName { get; set; }
        public int Color { get; set; }

        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<Stage> Stages { get; set; }
        //public virtual ICollection<SalesUnit> SalesUnits { get; set; }
    }
}
