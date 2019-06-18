using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Activities;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;

namespace StartUp.CRM.Repository.Repository.Activities
{
  public class TaskTypeRepository : Repository<TaskType>, IRepository<TaskType>
  {
    public TaskTypeRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}