using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Currencies
{
    public class Currency : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int DigitsAfterDecimal { get; set; }
        public string CurrencySymbol { get; set; }
        public string ListSymbol { get; set; }
        public string DecimalSymbol { get; set; }
        public string Format { get; set; }
        public decimal ExchangeRate { get; set; }

        public virtual ICollection<ExchangeRateList> ExchangeRateList { get; set; }
        public virtual ICollection<Opportunities.Opportunity> Opportunity { get; set; }
    }
}
