using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Activities
{
    public class Call : ActivityBaseEntity
    {
        public Nullable<int> Priority { get; set; }
        public double Ordinal { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<int> DurationHours { get; set; }
        public Nullable<int> DurationMinutes { get; set; }
        public string Description { get; set; }
    }
}
