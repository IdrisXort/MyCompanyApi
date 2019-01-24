using ApiCompany.Business.AbstractClasses;
using ApiCompany.Business.BusinessInterfaces;
using ApiCompany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCompany.Business.GenericController
{
    public class GenericController<Tco> : Processable<Tco, int>, IGenericController<Tco> where Tco : BaseDomain<int>,  IProcessable<Tco>
    {
        public GenericController(DbContext context) : base(context)
        {
        }

        public Task AddData(Tco t)
        {
            throw new NotImplementedException();
        }

        public Task<Tco> DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tco> GetData()
        {
            throw new NotImplementedException();
        }

        public Task<Tco> GetDataById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateData(int id, Tco t)
        {
            throw new NotImplementedException();
        }
    }
}
