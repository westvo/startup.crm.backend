using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Activities
{
    public class Reminder : ActivityBaseEntity
    {
        public string Name { get; set; }
        public System.DateTime EndDate { get; set; }
        public int EndDateOffset { get; set; }
        public Nullable<System.Guid> ParentId { get; set; }
    }
}
