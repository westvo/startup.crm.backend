using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Model.Entities.Currencies
{
    public class ExchangeRateList : BaseEntity
    {
        public decimal Rate { get; set; }
        public System.Guid CurrencyId { get; set; }
        public System.Guid ExchangeRateId { get; set; }

        public virtual Currencies.Currency Currency { get; set; }
        public virtual ExchangeRate ExchangeRate { get; set; }
    }
}
