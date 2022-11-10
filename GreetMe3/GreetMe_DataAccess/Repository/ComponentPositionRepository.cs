using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace GreetMe_DataAccess.Repository
{
    public class ComponentPositionRepository : IComponentPositionRepository
    {

        //ConnectionString
        private readonly WEXO_GreetMeContext _db;
        public ComponentPositionRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* GetAll / Read                                                             */
        //-----------------------------------------------------------------------------

        //GetAll
        public IEnumerable<ComponentPosition> GetAll()
        {
            var componentPositions = _db.ComponentPositions;
            return componentPositions.ToList();
        }

        //GetAll Async
        public async Task<IEnumerable<ComponentPosition>> GetAllAsync()
        {
            return await _db.ComponentPositions.ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get
        public ComponentPosition? Get(int id)
        {
            return _db.ComponentPositions.Find(id);
        }

        //Get Async
        public async Task<ComponentPosition?> GetAsync(int id)
        {
            return await _db.ComponentPositions.FindAsync(id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public ComponentPosition? Create(ComponentPosition entity)
        {
            _db.ComponentPositions.Add(entity);
            _db.SaveChanges();
            return entity;
        }
        //Create Async
        public async Task<ComponentPosition?> CreateAsync(ComponentPosition entity)
        {
            _db.ComponentPositions.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public ComponentPosition Update(ComponentPosition entity)
        {
            _db.ComponentPositions.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        //Update Async
        public async Task<ComponentPosition?> UpdateAsync(ComponentPosition entity)
        {
            _db.ComponentPositions.Update(entity);
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
