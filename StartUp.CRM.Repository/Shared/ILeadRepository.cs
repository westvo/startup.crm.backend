using StartUp.CRM.Model.Entities.Leads;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Repository.Shared
{
    public interface ILeadRepository
    {
        Lead Get(Guid id);
        List<Lead> GetAll();
    }
}
