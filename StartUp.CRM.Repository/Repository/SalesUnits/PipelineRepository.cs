using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.SalesUnits;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;
                                                      
namespace StartUp.CRM.Repository.Repository.SalesUnits
{
  public class PipelineRepository : Repository<Pipeline>, IRepository<Pipeline>
  {
    public PipelineRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
