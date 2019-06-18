using System;
using System;
using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Currencies;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
                                                       
namespace StartUp.CRM.Repository.Repository.Currencies
{
  public class CurrencyRepository : Repository<Currency>, IRepository<Currency>
  {
    public CurrencyRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
