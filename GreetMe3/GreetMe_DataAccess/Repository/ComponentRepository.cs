using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Repository
{
    public class ComponentRepository : IComponentRepository
    {

        //ConnectionString
        private readonly WEXO_GreetMeContext _db;
        public ComponentRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        public IEnumerable<Component> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Component>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Component? Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Component?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        public bool Create(Component entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(Component entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        public bool Update(Component entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Component entity)
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
