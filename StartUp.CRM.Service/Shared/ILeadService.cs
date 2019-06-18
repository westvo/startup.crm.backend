using StartUp.CRM.Model.Entities.Leads;
using StartUp.CRM.UnitOfWork.Collections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.CRM.Service.Shared
{
    public interface ILeadService
    {
        Task<IPagedList<Lead>> GetAll();
        Lead Create(Lead lead);
    }
}
