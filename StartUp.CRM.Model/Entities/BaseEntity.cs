using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities
{
   public class BaseEntity
    {
        public System.Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public Nullable<System.Guid> OwnerId { get; set; }
        public int Flags { get; set; }
    }
}
