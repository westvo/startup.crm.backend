using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;

namespace StartUp.CRM.Repository.Repository.Accounts
{
  public class ContactRepository : Repository<Contact>, IRepository<Contact>
  {
    public ContactRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
