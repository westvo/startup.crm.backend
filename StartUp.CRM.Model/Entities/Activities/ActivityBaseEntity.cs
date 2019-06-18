using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Activities
{
    public class ActivityBaseEntity : BaseEntity
    {
        public string Subject { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.Guid> LinkedItemId { get; set; }
        public Nullable<int> LinkedItemType { get; set; }       
        public Nullable<System.Guid> AssigneeId { get; set; }
    }
}
