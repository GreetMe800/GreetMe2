using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
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
        /* Get / Read                                                                */
        //----------------------------------------------------------------------------- 

        public IEnumerable<Menu> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Menu>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Menu?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Menu? Get(int id)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        public bool Create(Menu entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(Menu entity)
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

        public Task<bool> UpdateAsync(Menu entity)
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

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
