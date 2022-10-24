using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Repository
{
    public class ScreenRepository : IScreenRepository
    {
        //ConnectionString
        private readonly WEXO_GreetMeContext _db;
        public ScreenRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* GetAll                                                                    */
        //-----------------------------------------------------------------------------

        //GetAll
        public IEnumerable<Screen> GetAll()
        {
            return _db.Screens.ToList();
        }

        //GetAll Aync
        public async Task<IEnumerable<Screen>> GetAllAsync()
        {
            return await _db.Screens.ToListAsync();
        }

        //GetAll WithDep
        //TODO

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //GetBy Id
        public Screen? GetById(int id)
        {
            return _db.Screens.FirstOrDefault(s => s.Id == id);
        }

        //GetBy Id Async
        public async Task<Screen?> GetByIdAsync(int id)
        {
            return await _db.Screens.FirstOrDefaultAsync(s => s.Id == id);
        }

        //GetBy Id WithDep
        //TODO

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        //Create
        public Screen? Create(Screen entity)
        {
            _db.Screens.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        //Create Async
        public async Task<Screen?> CreateAsync(Screen entity)
        {
            _db.Screens.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------

        //Update
        public Screen Update(Screen entity)
        {
            _db.Screens.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        //Update Async
        public async Task<Screen?> UpdateAsync(Screen entity)
        {
            _db.Screens.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------

        //Delete
        public void Delete(int id)
        {
            _db.Screens.Remove(GetById(id));
            _db.SaveChanges();
        }

        //Delete Async
        public async Task<bool> DeleteAsync(int id)
        {
            _db.Screens.Remove(await GetByIdAsync(id));
            return await _db.SaveChangesAsync() != 0;
        }

    }
}
