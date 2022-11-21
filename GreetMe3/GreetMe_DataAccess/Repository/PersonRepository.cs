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
        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _db.People
                .OrderBy(p => p.FullName)
                .ToListAsync();
        }

        //GetAll by Birthday
        public async Task<IEnumerable<Person>> GetAllByBirthday(DateTime datetime)
        {
            DateTime date = new DateTime(datetime.Year, datetime.Month, datetime.Day);
            return await _db.People
                .OrderBy(p => p.FullName)
                .Where(p => p.DateOfBirth.Month == date.Month && p.DateOfBirth.Day == date.Day)
                .ToListAsync();
        }

        //GetAll by Anniversary
        public async Task<IEnumerable<Person>> GetAllByAnniversary(DateTime datetime)
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
        public async Task<Person?> Get(int id)
        {
            return await _db.People
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        //Get By Email
        public async Task<Person?> GetByEmail(string email)
        {
            return await _db.People
                .FirstOrDefaultAsync(p => p.Email == email);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public async Task<Person> Create(Person entity)
        {
            _db.People.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //Update
        public /*async*/ Task<Person> Update(Person entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        //Delete
        public /*async*/ Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
