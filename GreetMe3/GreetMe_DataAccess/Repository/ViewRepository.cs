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
            var views = _db.Views;
            return views.ToList();
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

<<<<<<< HEAD
        //Get With Dep
        public View? GetWithDep(int id)
        {
            return _db.Views.Find(id);        
        }

=======
>>>>>>> Main_Sprint_3_asp_Spike
        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
<<<<<<< HEAD
        public View? Create(View entity)
=======
        public View Create(View entity)
>>>>>>> Main_Sprint_3_asp_Spike
        {
            _db.Views.Add(entity);
            _db.SaveChanges();
            return entity;
<<<<<<< HEAD
=======

>>>>>>> Main_Sprint_3_asp_Spike
        }
        //Create Async
<<<<<<< HEAD
        public async Task<View?> CreateAsync(View entity)
=======
        public async Task<View> CreateAsync(View entity)
>>>>>>> Main_Sprint_3_asp_Spike
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
<<<<<<< HEAD
        public async Task<View?> UpdateAsync(View entity)
=======
        public async Task<View> UpdateAsync(View entity)
>>>>>>> Main_Sprint_3_asp_Spike
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
            throw new NotImplementedException();
        }

        //Delete Async
        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
