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
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        public IEnumerable<Person> GetAll()
        {
            var persons = _db.People;
            return persons.ToList();
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _db.People.ToListAsync();
        }

        public Person? Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Person?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Person? GetAllByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Person?> GetAllByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        public bool Create(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(Person entity)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        public bool Update(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Person entity)
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
