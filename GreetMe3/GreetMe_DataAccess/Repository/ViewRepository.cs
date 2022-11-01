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

        public IEnumerable<View> GetAll()
        {
            var views = _db.Views;
            return views.ToList();
        }

        public async Task<IEnumerable<View>> GetAllAsync()
        {
            return await _db.Views.ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        public View? Get(int id)
        {
            return _db.ViewsComponents
                .Include(vc => vc.View)
                .Include(vc => vc.Component);
        }

        public async Task<View?> GetAsync(int id)
        {
            return await _db.Views.FindAsync(id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        public bool Create(View entity)
        {
            _db.Views.Add(entity);
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0

        }

        public async Task<bool> CreateAsync(View entity)
        {
            _db.Views.Add(entity);
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        public bool Update(View entity)
        {
            _db.Views.Update(entity);
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0
        }

        public async Task<bool> UpdateAsync(View entity)
        {
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        public bool Delete(int id)
        {
            _db.Views.Remove(Get(id));
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0
        }

        public async Task<bool> DeleteAsync(int id)
        {
            _db.Views.Remove(await GetAsync(id));
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }
    }
}
