using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Activities
{
    public class Appointment : ActivityBaseEntity
    {
        public string Location { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Description { get; set; }
    }
}
