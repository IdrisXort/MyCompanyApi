using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCompany.Business.BusinessInterfaces;
using ApiCompany.Business.GenericController;
using ApiCompany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : IGenericController<Skill>
    {
        private readonly IProcessable<Skill> _processable;
        public SkillsController(IProcessable<Skill> processable)
        {
            _processable = processable;
        }

        public Task AddData(Skill t)
        {
            return _processable.AddData(t);
        }

        public Task<Skill> DeleteData(int id)
        {
            return _processable.DeleteData(id);
        }
        [HttpGet]
        public IEnumerable<Skill> GetData()
        {
            return _processable.GetData();
        }
        [HttpGet("{id}")]
        public Task<Skill> GetDataById(int id)
        {
            return _processable.GetDataById(id);
        }

        public Task UpdateData(int id, Skill t)
        {
            return _processable.UpdateData(id, t);
        }
    }
}