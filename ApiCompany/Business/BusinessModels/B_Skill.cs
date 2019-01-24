using ApiCompany.Business.AbstractClasses;
using ApiCompany.Business.BusinessInterfaces;
using ApiCompany.Domein;
using ApiCompany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCompany.Business.BusinessModels
{
    public class B_Skill : Processable<Skill, int>, IProcessable<Skill>
    {
        private static DbContext _dbContext;
        public B_Skill(ApiDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public Task AddData(Skill t)
        {
            return this.AddDataDb(t);
        }

        public Task<Skill> DeleteData(int id)
        {
            return this.DeleteDataFromDb(id);
        }
        public IEnumerable<Skill> GetData()
        {
            return this.GetDataFromDb();
        }

        public Task<Skill> GetDataById(int id)
        {
            return this.GetDataFromDbById(id);
        }

        public Task UpdateData(int id, Skill t)
        {
            return this.UpdateDataDb(id, t);
        }
    }
}
