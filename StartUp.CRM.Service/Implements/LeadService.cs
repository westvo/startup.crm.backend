using Microsoft.Extensions.Logging;
using StartUp.CRM.Model.Entities.Leads;
using StartUp.CRM.UnitOfWork.Collections;
using StartUp.CRM.UnitOfWork.Shared;
using StartUp.CRM.Service.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.CRM.Service.Implements
{
    public class LeadService : ILeadService
    {
        IUnitOfWork _unitOfWork;

        public LeadService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Lead Create(Lead lead)
        {
            var Id = new Guid();
            lead.Id = Id;

            _unitOfWork.GetRepository<Lead>().Insert(lead);
            return lead;
        }

        public async Task<IPagedList<Lead>> GetAll()
        {
            return await _unitOfWork.GetRepository<Lead>().GetPagedListAsync();
        }
    }
}
