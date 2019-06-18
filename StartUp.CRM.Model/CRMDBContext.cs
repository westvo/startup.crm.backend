using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StartUp.CRM.Model.Entities.Accounts;
using StartUp.CRM.Model.Entities.Activities;
using StartUp.CRM.Model.Entities.Campaigns;
using StartUp.CRM.Model.Entities.Currencies;
using StartUp.CRM.Model.Entities.Leads;
using StartUp.CRM.Model.Entities.Opportunities;
using StartUp.CRM.Model.Entities.Products;
using StartUp.CRM.Model.Entities.SalesUnits;
using System.Collections.Generic;

namespace StartUp.CRM.Model
{
    public class CRMDBContext : DbContext
    {
        public CRMDBContext(DbContextOptions<CRMDBContext> options)
            : base(options)
        { }

        public DbSet<AccountAudit> AccountAudits { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<AddressBook> AddressBooks { get; set; }
        public DbSet<ContactAudit> ContactAudits { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Industry> Industries { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Call> Calls { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }


        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CampaignAudit> CampaignAudits { get; set; }
        public DbSet<CampaignLog> CampaignLogs { get; set; }
        public DbSet<CampaignTracker> CampaignTrackers { get; set; }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<ExchangeRateList> ExchangeRateLists { get; set; }

        public DbSet<Lead> Leads { get; set; }
        public DbSet<LeadAudit> LeadAudits { get; set; }
        public DbSet<LeadSource> LeadSources { get; set; }


        public DbSet<ProductPriceList> ProductPriceLists { get; set; }
        public DbSet<ProductPriceListDetail> ProductPriceListDetails { get; set; }

        public DbSet<SalesUnit> SalesUnits { get; set; }
        public DbSet<Pipeline> Pipelines { get; set; }
        public DbSet<StageCustomField> StageCustomFields { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<StageCheckedList> StageCheckedLists { get; set; }

        public DbSet<OpportunityType> OpportunityTypes { get; set; }
        public DbSet<LostReason> LostReasons { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<OpportunityAudit> OpportunityAudits { get; set; }
        public DbSet<OpportunityProduct> OpportunityProducts { get; set; }
        public DbSet<Target> Targets { get; set; }


        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();

            base.OnModelCreating(modelBuilder);
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }
        }
    }
}

