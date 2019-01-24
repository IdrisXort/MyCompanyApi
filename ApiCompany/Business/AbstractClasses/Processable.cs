using ApiCompany.Business.BusinessInterfaces;
using ApiCompany.Business.Exceptions;
using ApiCompany.Business.GenericController;
using ApiCompany.Domein;
using ApiCompany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCompany.Business.AbstractClasses
{
    public abstract class Processable<T, TId> where T : BaseDomain<TId>
    {

        private readonly DbContext _context;
        // ctor

        public Processable(DbContext context)
        {
            _context = context;
        }

        public  IEnumerable<T> GetDataFromDb()
        {
            return _context.Set<T>();
        }
        
        public async Task<T> GetDataFromDbById(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        public async Task UpdateDataDb(int id, T t)
        {
            _context.Entry(t).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(id))
                {
                    throw new EntityNotFoundException();
                }
                throw;
            }
        }
        public async Task AddDataDb(T t)
        {
            _context.Set<T>().Add(t);
            await _context.SaveChangesAsync();
        }
        public async Task<T> DeleteDataFromDb(int id)
        {
            var project = await _context.Set<T>().FindAsync(id);
            if (project == null)
            {
                throw new EntityNotFoundException();
            }

            _context.Set<T>().Remove(project);
            await _context.SaveChangesAsync();

            return project;
        }

        private bool ProjectExists(int id)
        {
            return _context.Set<T>().Any(e => e.Id.Equals(id));
        }
    }
}
