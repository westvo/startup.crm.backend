using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;

namespace StartUp.CRM.Repository.Repository.Accounts
{
  public class ContactAuditRepository : Repository<ContactAudit>, IRepository<ContactAudit>
  {
    public ContactAuditRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
