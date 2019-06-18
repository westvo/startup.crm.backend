using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Activities;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;

namespace StartUp.CRM.Repository.Repository.Activities
{
  public class ReminderRepository : Repository<Reminder>, IRepository<Reminder>
  {
    public ReminderRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}