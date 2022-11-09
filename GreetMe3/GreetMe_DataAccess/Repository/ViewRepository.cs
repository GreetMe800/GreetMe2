using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;

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

        //Get With Dep
        public View? GetWithDep(int id)
        {           
            return _db.Views
                .Include(view => view.Layout)
                .ThenInclude(layout => layout.ComponentPositions)
                .ThenInclude(componentPosition => componentPosition.Component)
                .FirstOrDefault(view => view.Id == id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public bool Create(View entity)
        {
          
           

            _db.Views.Add(entity);
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0

        }

        //Create Async
        public async Task<bool> CreateAsync(View entity)
        {

            try
            {
                _db.Views.Add(entity);
                return _db.SaveChanges() != 0;
            }
            catch (Exception e)
            {
                int i = 1;
            }

            _db.Views.Add(entity);
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }

        //Create (Returns object insted of bool - for test)
        public View CreateTest(View entity)
        {
            _db.Views.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public bool Update(View entity)
        {
            _db.Views.Update(entity);
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0
        }

        //Update Async
        public async Task<bool> UpdateAsync(View entity)
        {
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
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
