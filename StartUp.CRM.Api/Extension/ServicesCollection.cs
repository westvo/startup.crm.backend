using Microsoft.Extensions.DependencyInjection;
using StartUp.CRM.Service.Implements;
using StartUp.CRM.Service.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartUp.CRM.Api.Extension
{
    public static class ServicesCollection
    {
        public static IServiceCollection AddServicesInstance(this IServiceCollection service)
        {
            //service.AddTransient<IAuthService, AuthService>();
            service.AddScoped<ILeadService, LeadService>();
            return service;
        }
    }
}
