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

        //GetAll Async
        public async Task<IEnumerable<Menu>> GetAll()
        {
            return await _db.Menus
                .OrderBy(p => p.MenuName)
                .ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get
        public async Task<Menu?> Get(int id)
        {
            return await _db.Menus
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public /*async*/ Task<Menu> Create(Menu entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public /*async*/ Task<Menu> Update(Menu entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        //Delete
        public /*async*/ Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
