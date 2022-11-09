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

        //Getall Async
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
            return _db.ComponentPositions.FirstOrDefault(p => p.Id == id);
        }

        //Get Async
        public async Task<ComponentPosition?> GetAsync(int id)
        {
            return await _db.ComponentPositions.FirstOrDefaultAsync(p => p.Id == id);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public bool Create(ComponentPosition entity)
        {
            _db.ComponentPositions.Add(entity);
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0

        }

        //Create Async
        public async Task<bool> CreateAsync(ComponentPosition entity)
        {
            _db.ComponentPositions.Add(entity);
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }

        //Create (Returns object insted of bool - for test)
        public ComponentPosition CreateTest(ComponentPosition entity)
        {
            _db.ComponentPositions.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public bool Update(ComponentPosition entity)
        {
            _db.ComponentPositions.Update(entity);
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0
        }

        //Update Async
        public async Task<bool> UpdateAsync(ComponentPosition entity)
        {
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        //Delete
        public bool Delete(int id)
        {
            _db.ComponentPositions.Remove(Get(id));
            return _db.SaveChanges() != 0; //retuens true if numb of effected rows is not 0
        }

        //Delete Async
        public async Task<bool> DeleteAsync(int id)
        {
            _db.ComponentPositions.Remove(await GetAsync(id));
            return await _db.SaveChangesAsync() != 0; //retuens true if numb of effected rows is not 0
        }
    }
}
