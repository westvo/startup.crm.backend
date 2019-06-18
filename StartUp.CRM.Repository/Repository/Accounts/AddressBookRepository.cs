using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;

namespace StartUp.CRM.Repository.Repository.Accounts
{
  public class AddressBookRepository : Repository<AddressBook>, IRepository<AddressBook>
  {
    public AddressBookRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
