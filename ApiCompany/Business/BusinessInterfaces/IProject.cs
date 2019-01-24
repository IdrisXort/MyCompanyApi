using ApiCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCompany.Business.BusinessInterfaces
{
    public interface IProject
    {
        IEnumerable<Project> GetData();
        Task<Project> GetDataById(int id);
        Task UpdateData(int id, Project t);
        Task AddData(Project t);
        Task<Project> DeleteData(int id);
    }
}
