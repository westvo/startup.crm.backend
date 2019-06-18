using System;
using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Campaigns;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
                                                       
namespace StartUp.CRM.Repository.Repository.Campaigns
{
  public class CampaignAuditRepository : Repository<CampaignAudit>, IRepository<CampaignAudit>
  {
    public CampaignAuditRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
