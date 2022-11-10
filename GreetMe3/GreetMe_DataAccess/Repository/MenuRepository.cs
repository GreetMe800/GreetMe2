using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace GreetMe_DataAccess.Repository
{
    public class MenuRepository : IMenuRepository
    {

        //ConnectionString
        private readonly WEXO_GreetMeContext _db;
        public MenuRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* GetAll / Read                                                             */
        //-----------------------------------------------------------------------------

        //GetAll
        public IEnumerable<Menu> GetAll()
        {
            var menus = _db.Menus;
            return menus.ToList();
        }

        //GetAll Async
        public async Task<IEnumerable<Menu>> GetAllAsync()
        {
            return await _db.Menus.ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get
        public Menu? Get(int id)
        {
            return _db.Menus.Find(id);
        }

        //Get Async
        public async Task<Menu?> GetAsync(int id)
        {
            return await _db.Menus.FindAsync(id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public Menu? Create(Menu entity)
        {
            _db.Menus.Add(entity);
            _db.SaveChanges();
            return entity;
        }
        //Create Async
        public async Task<Menu?> CreateAsync(Menu entity)
        {
            _db.Menus.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public Menu Update(Menu entity)
        {
            _db.Menus.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        //Update Async
        public async Task<Menu?> UpdateAsync(Menu entity)
        {
            _db.Menus.Update(entity);
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
