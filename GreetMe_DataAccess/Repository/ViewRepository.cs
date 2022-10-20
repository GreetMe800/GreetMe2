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
    public class ViewRepository : IViewRepository
    {
        //ConnectionString
        private readonly WEXO_GreetMeContext _db;
        public ViewRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* GetAll                                                                    */
        //-----------------------------------------------------------------------------

        //GetAll
        public IEnumerable<View> GetAll()
        {
            return _db.Views
                .ToList();
        }

        //GetAll Aync
        public async Task<IEnumerable<View>> GetAllAsync()
        {
            return await _db.Views
                .ToListAsync();
        }

        //GetAll WithDep
        //TODO

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //GetBy Id
        public View? GetById(int id)
        {
            return _db.Views
                .FirstOrDefault(v => v.Id == id);
        }

        //GetBy Id Async
        public async Task<View?> GetByIdAsync(int id)
        {
            return await _db.Views
                .FirstOrDefaultAsync(v => v.Id == id);
        }

        //GetBy Id WithDep
        public View? GetByIdWithDep(int id)
        {
            View? View = _db.Views
                .Include(s => s.Screens)
                .FirstOrDefault(x => x.Id == id);
            return View;
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        //Create
        public View? Create(View entity)
        {
            _db.Views.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        //Create Async
        public async Task<View?> CreateAsync(View entity)
        {
            _db.Views.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------

        //Update
        public View Update(View entity)
        {
            _db.Views.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        //Update Async
        public async Task<View> UpdateAsync(View entity)
        {
            _db.Views.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------

        //Delete
        public void Delete(int id)
        {
            _db.Views.Remove(GetById(id));
            _db.SaveChanges();
        }

        //Delete Async
        public async void DeleteAsync(int id)
        {
            _db.Views.Remove(await GetByIdAsync(id));
            await _db.SaveChangesAsync();
        }

    }
}
