using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Opportunities;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Repository.Repository.Opportunities
{
  public class OpportunityAuditRepository : Repository<OpportunityAudit>, IRepository<OpportunityAudit>
  {
    public OpportunityAuditRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
       