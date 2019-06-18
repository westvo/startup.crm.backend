using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Activities
{
    public class Task : ActivityBaseEntity
    {
        public Nullable<int> Priority { get; set; }
        public double Ordinal { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string Description { get; set; }
        public System.Guid TaskTypeId { get; set; }

        public virtual TaskType TaskType { get; set; }
    }
}
