using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Activities;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
                                                    
namespace StartUp.CRM.Repository.Repository.Activities
{
  public class CallRepository : Repository<Call>, IRepository<Call>
  {
    public CallRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}                             