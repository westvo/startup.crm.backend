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
  public class ExchangeRateListRepository : Repository<ExchangeRateList>, IRepository<ExchangeRateList>
  {
    public ExchangeRateListRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
