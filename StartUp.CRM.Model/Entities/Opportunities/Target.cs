using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Opportunities
{
    public class Target : BaseEntity
    {
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public decimal Value { get; set; }
    }
}
