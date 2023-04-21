using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.ApplicationCore.Contract.Repository;
using HRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly HRMDbContext _context;

        public BaseRepository(HRMDbContext context)
        {
            _context = context;
        }

     public async Task<int> DeleteAsync(int id)
        {

            /*var customer = dbContext.Customers.Find(1);
            var deletedCustomer = dbContext.Customers.Remove(customer);
            dbContext.SaveChanges();*/
           var entity = await _context.Set<T>().FindAsync(id);
           if(entity != null){
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
           }
           return 0;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<int> InsertAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
          _context.Entry(entity).State = EntityState.Modified;
          return await _context.SaveChangesAsync();
        }
    }
}