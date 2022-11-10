using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;

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
            return _db.Components.Find(id);
        }

        //Get Async
        public async Task<Component?> GetAsync(int id)
        {
            return await _db.Components.FindAsync(id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public Component? Create(Component entity)
        {
            _db.Components.Add(entity);
            _db.SaveChanges();
            return entity;
        }
        //Create Async
        public async Task<Component?> CreateAsync(Component entity)
        {
            _db.Components.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public Component Update(Component entity)
        {
            _db.Components.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        //Update Async
        public async Task<Component?> UpdateAsync(Component entity)
        {
            _db.Components.Update(entity);
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
