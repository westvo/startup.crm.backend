using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Opportunities;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;
                                                   
namespace StartUp.CRM.Repository.Repository.Opportunities
{
  public class LostReasonRepository : Repository<LostReason>, IRepository<LostReason>
  {
    public LostReasonRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
