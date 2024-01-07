using Microsoft.EntityFrameworkCore;
using HappyPetDataAccessLayer.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HappyPetDataAccessLayer.Concrete
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {
        protected readonly DbContext _context;

        public GenericDal(DbContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByID(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
