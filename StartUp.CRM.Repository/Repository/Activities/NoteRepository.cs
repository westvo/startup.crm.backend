using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Activities;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
                                                    
namespace StartUp.CRM.Repository.Repository.Activities
{
  public class NoteRepository : Repository<Note>, IRepository<Note>
  {
    public NoteRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}