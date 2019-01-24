using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCompany.Business.AbstractClasses;
using ApiCompany.Business.BusinessInterfaces;
using ApiCompany.Business.BusinessModels;
using ApiCompany.Business.GenericController;
using ApiCompany.Domein;
using ApiCompany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCompany.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : IGenericController<Project>
    {
        private readonly IProcessable<Project> _processable;
        public ProjectsController(IProcessable<Project> processable)
        {
            _processable = processable;
        }
        [HttpPost]
        public Task AddData(Project t)
        {
            return _processable.AddData(t);
        }
        [HttpPost]
        public Task<Project> DeleteData(int id)
        {
            return _processable.DeleteData(id);
        }
        [HttpGet]
        public IEnumerable<Project> GetData()
        {
            return _processable.GetData();
        }
        [HttpGet("{id}")]
        public Task<Project> GetDataById(int id)
        {
            return _processable.GetDataById(id);
        }
        [HttpPut]
        public Task UpdateData(int id, Project t)
        {
            return _processable.UpdateData(id, t);
        }
    }
}