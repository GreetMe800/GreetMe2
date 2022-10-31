using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreetMe_DataAccess.DataAccess;

namespace GreetMe_DataAccess.Repository
{
    public class MenuRepository : IMenuRepository
    {

        //ConnectionString
        private readonly MenuContext _db;
        public MenuRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* GetAll / Read                                                             */
        //-----------------------------------------------------------------------------

        public IEnumerable<Menu> GetAll()
        {
            var menus = _db.Menus;
            return menus.ToList();
        }

        public async Task<IEnumerable<Menu>> GetAllAsync()
        {
            return await _db.Menus.ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        public Menu? Get(int id)
        {
            return _db.Menus.FirstOrDefault(p => p.Id == id);
        }

        public async Task<Menu?> GetAsync(int id)
        {
            return await _db.Menus.FirstOrDefaultAsync(p => p.Id == id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        public bool Create(Menu entity)
        {
            throw new NotImplementedException();

        }

        public async Task<bool> CreateAsync(Menu entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        public bool Update(Menu entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Menu entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
