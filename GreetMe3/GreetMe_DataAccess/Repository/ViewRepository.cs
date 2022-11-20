using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

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
        /* GetAll / Read                                                             */
        //-----------------------------------------------------------------------------

        //GetAll
        public IEnumerable<View> GetAll()
        {
            return _db.Views;
        }

        //GetAll Async
        public async Task<IEnumerable<View>> GetAllAsync()
        {
            return await _db.Views.ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get
        public View? Get(int id)
        {
            return _db.Views.Find(id);
        }

        //Get Async
        public async Task<View?> GetAsync(int id)
        {
            return await _db.Views.FindAsync(id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public View Create(View entity)
        {
            _db.Views.Add(entity);
            _db.SaveChanges();
            return entity;

        }

        //Create Async
        public async Task<View> CreateAsync(View entity)
        {
            _db.Views.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
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
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        //Delete
        public bool Delete(int id)
        {
            _db.Views.Remove(Get(id));
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0
        }

        //Delete Async
        public async Task<bool> DeleteAsync(int id)
        {
            _db.Views.Remove(await GetAsync(id));
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }
    }
}
