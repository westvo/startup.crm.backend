using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Activities
{
    public class TaskType : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
