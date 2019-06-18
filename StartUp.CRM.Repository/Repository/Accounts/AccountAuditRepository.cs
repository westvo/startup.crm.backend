using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Repository.Repository.Accounts
{
  public class AccountAuditRepository : Repository<AccountAudit>, IRepository<AccountAudit>
  {
    public AccountAuditRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
