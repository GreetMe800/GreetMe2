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
        public async Task<IEnumerable<View>> GetAll()
        {
            return await _db.Views.OrderBy(p => p.ViewName).ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get
        public async Task<View?> Get(int id)
        {
            return await _db.Views.FindAsync(id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public async Task<View> Create(View entity)
        {
            _db.Views.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public async Task<View> Update(View entity)
        {
            _db.Views.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        //Delete
        public async Task<bool> Delete(int id)
        {
            _db.Views.Remove(await Get(id));
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }
    }
}
