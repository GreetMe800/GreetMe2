using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Repository
{
    public class LayoutRepository : ILayoutRepository
    {

        //ConnectionString
        private readonly WEXO_GreetMeContext _db;
        public LayoutRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        public IEnumerable<Layout> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Layout>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Layout? Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Layout?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        public bool Create(Layout entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(Layout entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        public bool Update(Layout entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Layout entity)
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
