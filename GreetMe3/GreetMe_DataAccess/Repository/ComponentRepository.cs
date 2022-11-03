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
    public class ComponentRepository : IComponentRepository
    {

        //ConnectionString
        private readonly WEXO_GreetMeContext _db;
        public ComponentRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* GetAll / Read                                                             */
        //-----------------------------------------------------------------------------

        //GetAll
        public IEnumerable<Component> GetAll()
        {
            var components = _db.Components;
            return components.ToList();
        }

        //GetAll Async
        public async Task<IEnumerable<Component>> GetAllAsync()
        {
            return await _db.Components.ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get
        public Component? Get(int id)
        {
            return _db.Components.FirstOrDefault(p => p.Id == id);
        }

        //Get Async
        public async Task<Component?> GetAsync(int id)
        {
            return await _db.Components.FirstOrDefaultAsync(p => p.Id == id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public bool Create(Component entity)
        {
            throw new NotImplementedException();

        }

        //Create Async
        public async Task<bool> CreateAsync(Component entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public bool Update(Component entity)
        {
            throw new NotImplementedException();
        }

        //Update Async
        public async Task<bool> UpdateAsync(Component entity)
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
