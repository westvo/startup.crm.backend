using StartUp.CRM.Model;
using StartUp.CRM.Model.Entities.Products;
using StartUp.CRM.UnitOfWork.Repositories;
using StartUp.CRM.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.CRM.Repository.Repository.Products
{
  public class ProductPriceListRepository : Repository<ProductPriceList>, IRepository<ProductPriceList>
  {
    public ProductPriceListRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
