using ApiCompany.Business.AbstractClasses;
using ApiCompany.Business.BusinessInterfaces;
using ApiCompany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCompany.Business.GenericController
{
    public interface IGenericController<T>:IProcessable<T>where T:BaseDomain<int>
    {
        IEnumerable<T> GetData();
        Task<T> GetDataById(int id);
        Task UpdateData(int id, T t);
        Task AddData(T t);
        Task<T> DeleteData(int id);

    }
}
