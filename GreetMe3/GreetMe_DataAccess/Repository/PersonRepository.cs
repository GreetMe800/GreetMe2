using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        /* GetAll / Read                                                             */
        //-----------------------------------------------------------------------------

        //GetAll
        public IEnumerable<Person> GetAll()
        {
            return _db.People
                .OrderBy(p => p.FullName)
                .ToList();
        }
        //GetAll Async
        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _db.People
                .OrderBy(p => p.FullName)
                .ToListAsync();
        }
        //GetAll by Birthday
        public IEnumerable<Person> GetAllByBirthday(DateTime datetime)
        {
            DateTime date = new DateTime(datetime.Year, datetime.Month, datetime.Day);
            return _db.People
                .OrderBy(p => p.FullName)
                .Where(p => p.DateOfBirth.Month == date.Month && p.DateOfBirth.Day == date.Day)
                .ToList();
        }
        //GetAll by Birthday Async
        public async Task<IEnumerable<Person>> GetAllByBirthdayAsync(DateTime datetime)
        {
            DateTime date = new DateTime(datetime.Year, datetime.Month, datetime.Day);
            return await _db.People
                .OrderBy(p => p.FullName)
                .Where(p => p.DateOfBirth.Month == date.Month && p.DateOfBirth.Day == date.Day)
                .ToListAsync();
        }

        //GetAll by Anniversary
        public IEnumerable<Person> GetAllByAnniversary(DateTime datetime)
        {
            DateTime date = new DateTime(datetime.Year, datetime.Month, datetime.Day);
            return _db.People
                .OrderBy(p => p.FullName)
                .Where(p => p.HiringDate.Month == date.Month && p.HiringDate.Day == date.Day)
                .ToList();
        }

        //GetAll by Anniversary Async
        public async Task<IEnumerable<Person>> GetAllByAnniversaryAsync(DateTime datetime)
        {
            DateTime date = new DateTime(datetime.Year, datetime.Month, datetime.Day);
            return await _db.People
                .OrderBy(p => p.FullName)
                .Where(p => p.HiringDate.Month == date.Month && p.HiringDate.Day == date.Day)
                .ToListAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get
        public Person? Get(int id)
        {
            return _db.People
                .FirstOrDefault(p => p.Id == id);
        }

        //Get Async
        public async Task<Person?> GetAsync(int id)
        {
            return await _db.People
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        //Get By Email
        public Person? GetByEmail(string email)
        {
            return _db.People
                .FirstOrDefault(p => p.Email == email);
        }

        //Get By Email Async
        public async Task<Person?> GetByEmailAsync(string email)
        {
            return await _db.People
                .FirstOrDefaultAsync(p => p.Email == email);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public Person Create(Person entity)
        {
            _db.People.Add(entity);
            _db.SaveChanges();
            return entity;
           
        }

        //Create Async
        public async Task<Person> CreateAsync(Person entity)
        {
            _db.People.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public Person Update(Person entity)
        {
            throw new NotImplementedException();
        }

        //Update Async
        public async Task<Person> UpdateAsync(Person entity)
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
