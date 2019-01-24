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
    public class B_User : Processable<User, int>, IProcessable<User>
    {
        private static DbContext _dbContext;
        public B_User(ApiDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public Task AddData(User t)
        {
            return this.AddDataDb(t);
        }

        public Task<User> DeleteData(int id)
        {
            return this.DeleteDataFromDb(id);
        }
        public IEnumerable<User> GetData()
        {
            return this.GetDataFromDb();
        }

        public Task<User> GetDataById(int id)
        {
            return this.GetDataFromDbById(id);
        }

        public Task UpdateData(int id, User t)
        {
            return this.UpdateDataDb(id, t);
        }
    }
}
