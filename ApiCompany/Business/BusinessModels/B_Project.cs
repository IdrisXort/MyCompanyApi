using ApiCompany.Business.AbstractClasses;
using ApiCompany.Business.BusinessInterfaces;
using ApiCompany.Business.Exceptions;
using ApiCompany.Business.GenericController;
using ApiCompany.Domein;
using ApiCompany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiCompany.Business.BusinessModels
{

    public class B_Project : Processable<Project, int>,IProcessable<Project>
    {
        
        private static DbContext _dbContext;

        public B_Project(ApiDbContext context) : base(context)
        {
        }

        public Task AddData(Project t)
        {
            return this.AddDataDb(t);
        }

        public Task<Project> DeleteData(int id)
        {
            return this.DeleteDataFromDb(id);
        }
        public IEnumerable<Project> GetData()
        {
            return this.GetDataFromDb();
        }

        public Task<Project> GetDataById(int id)
        {
            return this.GetDataFromDbById(id);
        }

        public Task UpdateData(int id, Project t)
        {
            return this.UpdateDataDb(id, t);
        }
    }
}

