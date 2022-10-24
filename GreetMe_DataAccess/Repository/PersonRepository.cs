using GreetMe_DataAccess.DTO;
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
    public class PersonRepository : IPersonRepository
    {
        //ConnectionString
        private readonly WEXO_GreetMeContext _db;
        public PersonRepository()
        {
            _db = new WEXO_GreetMeContext();
        }

        //-----------------------------------------------------------------------------
        /* GetAll                                                                    */
        //-----------------------------------------------------------------------------

        //GetAll
        public IEnumerable<Person> GetAll()
        {
            return _db.People.ToList();
        }

        //GetAll Aync
        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _db.People.ToListAsync();
        }

        //GetAll WithDep
        //TODO

        //GetAll by Birthday
        public IEnumerable<Person> GetAllByBirthday(DateTime datetime)
        {
            return _db.People.Where(p => p.DateOfBirth.Equals(datetime.Month) && p.DateOfBirth.Equals(datetime.Day)).ToList();
        }

        //GetAll by Birthday Async
        public async Task<IEnumerable<Person>> GetAllByBirthdayAsync(DateTime datetime)
        {
            return await _db.People.Where(p => p.DateOfBirth.Equals(datetime.Month) && p.DateOfBirth.Equals(datetime.Day)).ToListAsync();
        }

        //GetAll by Anniversary
        public IEnumerable<Person> GetAllByAnniversary(DateTime datetime)
        {
            return _db.People.Where(p => p.HiringDate.Equals(datetime.Month) && p.HiringDate.Equals(datetime.Day)).ToList();
        }

        //GetAll by Anniversary Async
        public async Task<IEnumerable<Person>> GetAllByAnniversaryAsync(DateTime datetime)
        {
            return await _db.People.Where(p => p.HiringDate.Equals(datetime.Month) && p.HiringDate.Equals(datetime.Day)).ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //GetBy Id
        public Person? GetById(int id)
        {
            return _db.People.FirstOrDefault(p => p.Id == id);
        }

        //GetBy Id Async
        public async Task<Person?> GetByIdAsync(int id)
        {
            return await _db.People.FirstOrDefaultAsync(p => p.Id == id);
        }

        //GetBy Id WithDep
            //TODO

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        //Create
        public Person? Create(Person entity)
        {
            _db.People.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        //Create Async
        public async Task<Person?> CreateAsync(Person entity)
        {
            _db.People.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------

        //Update
        public Person Update(Person entity)
        {
            _db.People.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        //Update Async
        public async Task<Person> UpdateAsync(Person entity)
        {
            _db.People.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------

        //Delete
        public void Delete(int id)
        {
            _db.People.Remove(GetById(id));
            _db.SaveChanges();
        }

        //Delete Async
        public async Task<bool> DeleteAsync(int id)
        {
            _db.People.Remove(await GetByIdAsync(id));
            return await _db.SaveChangesAsync() != 0;
        }
    }
}
