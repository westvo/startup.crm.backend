using System;
using System.Collections.Generic;
using System;
using System;
using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Currencies;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;

namespace StartUp.CRM.Repository.Repository.Currencies
{
  public class ExchangeRateRepository : Repository<ExchangeRate>, IRepository<ExchangeRate>
  {
    public ExchangeRateRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
