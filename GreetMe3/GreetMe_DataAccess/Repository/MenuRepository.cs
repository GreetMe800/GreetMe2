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
            return _db.Menus;
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
            return _db.Menus.FirstOrDefault(p => p.Id == id);
        }

        //Get Async
        public async Task<Menu?> GetAsync(int id)
        {
            return await _db.Menus.FirstOrDefaultAsync(p => p.Id == id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public Menu Create(Menu entity)
        {
            throw new NotImplementedException();

        }

        //Create Async
        public async Task<Menu> CreateAsync(Menu entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public Menu Update(Menu entity)
        {
            throw new NotImplementedException();
        }

        //Update Async
        public async Task<Menu> UpdateAsync(Menu entity)
        {
            throw new NotImplementedException();
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
