using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Leads;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Repository.Repository.Leads
{
  public class LeadSourceRepository : Repository<LeadSource>, IRepository<LeadSource>
  {
    public LeadSourceRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
