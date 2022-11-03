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
    public class LayoutRepository : ILayoutRepository
    {

        //ConnectionString
        private readonly WEXO_GreetMeContext _db;
        public LayoutRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* GetAll / Read                                                             */
        //-----------------------------------------------------------------------------

        //GetAll
        public IEnumerable<Layout> GetAll()
        {
            var layouts = _db.Layouts;
            return layouts.ToList();
        }

        //GetAll Async
        public async Task<IEnumerable<Layout>> GetAllAsync()
        {
            return await _db.Layouts.ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get
        public Layout? Get(int id)
        {
            return _db.Layouts.FirstOrDefault(p => p.ViewId == id);
        }

        //Get Async
        public async Task<Layout?> GetAsync(int id)
        {
            return await _db.Layouts.FirstOrDefaultAsync(p => p.ViewId == id);
        }

        //Get With Dep (without view)
        public Layout? Get(int id)
        {
            return _db.Layouts.FirstOrDefault(p => p.ViewId == id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public bool Create(Layout entity)
        {
            _db.Layouts.Add(entity);
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0

        }

        //Create Async
        public async Task<bool> CreateAsync(Layout entity)
        {
            _db.Layouts.Add(entity);
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public bool Update(Layout entity)
        {
            _db.Layouts.Update(entity);
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0
        }

        //Update Async
        public async Task<bool> UpdateAsync(Layout entity)
        {
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        //Delete
        public bool Delete(int id)
        {
            _db.Layouts.Remove(Get(id));
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0
        }

        //Delete Async
        public async Task<bool> DeleteAsync(int id)
        {
            _db.Layouts.Remove(await GetAsync(id));
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }
    }
}
