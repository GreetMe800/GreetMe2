using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;

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
            return _db.Layouts.Find(id);
        }

        //Get Async
        public async Task<Layout?> GetAsync(int id)
        {
            return await _db.Layouts.FindAsync(id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public Layout? Create(Layout entity)
        {
            _db.Layouts.Add(entity);
            _db.SaveChanges();
            return entity;
        }
        //Create Async
        public async Task<Layout?> CreateAsync(Layout entity)
        {
            _db.Layouts.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public Layout Update(Layout entity)
        {
            _db.Layouts.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        //Update Async
        public async Task<Layout?> UpdateAsync(Layout entity)
        {
            _db.Layouts.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        //Delete
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        //Delete Async
        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
