using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;

namespace StartUp.CRM.Repository.Repository.Accounts
{
  public class IndustryRepository : Repository<Industry>, IRepository<Industry>
  {
    public IndustryRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
