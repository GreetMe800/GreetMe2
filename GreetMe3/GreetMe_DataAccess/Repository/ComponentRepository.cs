//using GreetMe_DataAccess.DataAccess;
//using GreetMe_DataAccess.Interface;
//using GreetMe_DataAccess.Model;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GreetMe_DataAccess.Repository
//{
//    public class ComponentRepository : IComponentRepository
//    {

//        //ConnectionString
//        private readonly ComponentContext _db;
//        public ComponentRepository()
//        {
//            _db = new ComponentContext();
//        }

//        //-----------------------------------------------------------------------------
//        /* GetAll / Read                                                             */
//        //-----------------------------------------------------------------------------

//        public IEnumerable<Component> GetAll()
//        {
//            var components = _db.Components;
//            return components.ToList();
//        }

//        public async Task<IEnumerable<Component>> GetAllAsync()
//        {
//            return await _db.Components.ToListAsync();
//        }

//        //-----------------------------------------------------------------------------
//        /* Get / Read                                                                */
//        //-----------------------------------------------------------------------------

//        public Component? Get(int id)
//        {
//            return _db.Components.FirstOrDefault(p => p.Id == id);
//        }

//        public async Task<Component?> GetAsync(int id)
//        {
//            return await _db.Components.FirstOrDefaultAsync(p => p.Id == id);
//        }

//        //-----------------------------------------------------------------------------
//        /* Create / Post                                                             */
//        //-----------------------------------------------------------------------------

//        public bool Create(Component entity)
//        {
//            throw new NotImplementedException();

//        }

//        public async Task<bool> CreateAsync(Component entity)
//        {
//            throw new NotImplementedException();
//        }

//        //-----------------------------------------------------------------------------
//        /* Update / Put                                                              */
//        //-----------------------------------------------------------------------------

//        public bool Update(Component entity)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> UpdateAsync(Component entity)
//        {
//            throw new NotImplementedException();
//        }

//        //-----------------------------------------------------------------------------
//        /* Delete / Remove                                                           */
//        //-----------------------------------------------------------------------------

//        public bool Delete(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> DeleteAsync(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
