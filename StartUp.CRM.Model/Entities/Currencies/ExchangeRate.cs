using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Currencies
{
    public class ExchangeRate : BaseEntity
    {
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }

        public virtual ICollection<ExchangeRateList> ExchangeRateList { get; set; }
    }
}
