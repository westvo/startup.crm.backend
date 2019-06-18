using Microsoft.Extensions.DependencyInjection;
using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.Model.Entities.Activities;
using StartUp.CRM.Model.Entities.Campaigns;
using StartUp.CRM.Model.Entities.Currencies;
using StartUp.CRM.Model.Entities.Leads;
using StartUp.CRM.Model.Entities.Opportunities;
using StartUp.CRM.Model.Entities.Products;
using StartUp.CRM.Model.Entities.SalesUnits;
using StartUp.CRM.Repository.Repository.Accounts;
using StartUp.CRM.Repository.Repository.Activities;
using StartUp.CRM.Repository.Repository.Campaigns;
using StartUp.CRM.Repository.Repository.Currencies;
using StartUp.CRM.Repository.Repository.Leads;
using StartUp.CRM.Repository.Repository.Opportunities;
using StartUp.CRM.Repository.Repository.Products;
using StartUp.CRM.Repository.Repository.SalesUnits;
using StartUp.CRM.UnitOfWork.Shared;

namespace StartUp.CRM.Repository.Extension
{
  public static class RepositoryCollection
  {
    public static IServiceCollection AddRepositoriesInstance(this IServiceCollection service)
    {
      //service.AddScoped<IUnitOfWork, UnitOfWork>();

      service.AddCustomRepository<AccountAudit, AccountAuditRepository>();
      service.AddCustomRepository<Account, AccountRepository>();
      service.AddCustomRepository<AccountType, AccountTypeRepository>();
      service.AddCustomRepository<AddressBook, AddressBookRepository>();
      service.AddCustomRepository<ContactAudit, ContactAuditRepository>();
      service.AddCustomRepository<Contact, ContactRepository>();
      service.AddCustomRepository<Industry, IndustryRepository>();

      service.AddCustomRepository<Appointment, AppointmentRepository>();
      service.AddCustomRepository<Call, CallRepository>();
      service.AddCustomRepository<Note, NoteRepository>();
      service.AddCustomRepository<Reminder, ReminderRepository>();
      service.AddCustomRepository<Task, TaskRepository>();
      service.AddCustomRepository<TaskType, TaskTypeRepository>();


      service.AddCustomRepository<Campaign, CampaignRepository>();
      service.AddCustomRepository<CampaignAudit, CampaignAuditRepository>();
      service.AddCustomRepository<CampaignLog, CampaignLogRepository>();
      service.AddCustomRepository<CampaignTracker, CampaignTrackerRepository>();

      service.AddCustomRepository<Currency, CurrencyRepository>();
      service.AddCustomRepository<ExchangeRate, ExchangeRateRepository>();
      service.AddCustomRepository<ExchangeRateList, ExchangeRateListRepository>();

      service.AddCustomRepository<Lead, LeadRepository>();
      service.AddCustomRepository<LeadAudit, LeadAuditRepository>();
      service.AddCustomRepository<LeadSource, LeadSourceRepository>();


      service.AddCustomRepository<ProductPriceList, ProductPriceListRepository>();
      service.AddCustomRepository<ProductPriceListDetail, ProductPriceListDetailRepository>();

      service.AddCustomRepository<SalesUnit, SalesUnitRepository>();
      service.AddCustomRepository<Pipeline, PipelineRepository>();
      service.AddCustomRepository<StageCustomField, StageCustomFieldRepository>();
      service.AddCustomRepository<Stage, StageRepository>();
      service.AddCustomRepository<StageCheckedList, StageCheckedListRepository>();

      service.AddCustomRepository<OpportunityType, OpportunityTypeRepository>();
      service.AddCustomRepository<LostReason, LostReasonRepository>();
      service.AddCustomRepository<Opportunity, OpportunityRepository>();
      service.AddCustomRepository<OpportunityAudit, OpportunityAuditRepository>();
      service.AddCustomRepository<OpportunityProduct, OpportunityProductRepository>();
      service.AddCustomRepository<Target, TargetRepository>();


      return service;
    }
  }
}
