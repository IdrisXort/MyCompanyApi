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
    public class UsersController : IGenericController<User>
    {
        private readonly IProcessable<User> _processable;
        public UsersController(IProcessable<User> processable)   
        {
            _processable = processable;
        }

        public Task AddData(User t)
        {
            return _processable.AddData(t);
        }
        [HttpPost]
        public Task<User> DeleteData(int id)
        {
            return _processable.DeleteData(id);
        }
        [HttpGet]
        public IEnumerable<User> GetData()
        {
            return _processable.GetData();
        }
        [HttpGet("{id}")]
        public Task<User> GetDataById(int id)
        {
            return _processable.GetDataById(id);
        }

        public Task UpdateData(int id, User t)
        {
            return _processable.UpdateData(id, t);
        }
    }
}