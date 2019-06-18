using Microsoft.Extensions.DependencyInjection;
using StartUp.CRM.Model.Entities;
using StartUp.CRM.Repository.Repositories;
using StartUp.CRM.Repository.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartUp.CRM.Api.Extension
{
    public static class RepositoryCollection
    {
        public static IServiceCollection AddRepositoriesInstance(this IServiceCollection service)
        {
            //service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddCustomRepository<Lead, LeadRepository>();
            return service;
        }
    }
}
