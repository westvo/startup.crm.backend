using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;

namespace StartUp.CRM.Repository.Repository.Accounts
{
  public class AccountRepository : Repository<Account>, IRepository<Account>
  {
    public AccountRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
