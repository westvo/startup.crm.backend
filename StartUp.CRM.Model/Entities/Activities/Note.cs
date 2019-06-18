using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Activities
{
    public class Note : ActivityBaseEntity
    {
        public int ZIndex { get; set; }
        public int PositionTop { get; set; }
        public int PositionLeft { get; set; }
        public int Color { get; set; }
        public string Description { get; set; }
    }
}
