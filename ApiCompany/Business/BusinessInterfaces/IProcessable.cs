using ApiCompany.Business.AbstractClasses;
using ApiCompany.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCompany.Business.BusinessInterfaces
{
    public interface IProcessable<T>
    {
        IEnumerable<T> GetData();
        Task<T> GetDataById(int id);    
        Task UpdateData(int id, T t);
        Task AddData(T t);
        Task<T> DeleteData(int id);
    }
}

