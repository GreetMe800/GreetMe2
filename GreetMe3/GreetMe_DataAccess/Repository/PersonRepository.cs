//using GreetMe_DataAccess.Interface;
//using GreetMe_DataAccess.Model;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Tasks;
//using GreetMe_DataAccess.DataAccess;

//namespace GreetMe_DataAccess.Repository
//{
//    public class PersonRepository : IPersonRepository
//    {

//        //ConnectionString
//        private readonly PersonContext _db;
//        public PersonRepository()
//        {
//            _db = new WEXO_GreetMeContext();
//        }

//        //-----------------------------------------------------------------------------
//        /* GetAll / Read                                                             */
//        //-----------------------------------------------------------------------------

//        //GetAll
//        public IEnumerable<Person> GetAll()
//        {
//            var persons = _db.People;
//            return persons.ToList();
//        }
//        //GetAll Async
//        public async Task<IEnumerable<Person>> GetAllAsync()
//        {
//            return await _db.People.ToListAsync();
//        }
//        //GetAll by Birthday
//        public IEnumerable<Person> GetAllByBirthday(DateTime datetime)
//        {
//            DateTime date = new DateTime(datetime.Year, datetime.Month, datetime.Day);
//            return _db.People.Where(p => p.DateOfBirth.Month == date.Month && p.DateOfBirth.Day == date.Day);
//        }
//        //GetAll by Birthday Async
//        public async Task<IEnumerable<Person>> GetAllByBirthdayAsync(DateTime datetime)
//        {
//            throw new NotImplementedException();
//            //return await _db.People.Where(p => p.DateOfBirth.Equals(datetime.Month) && p.DateOfBirth.Equals(datetime.Day)).ToListAsync();
//        }

//        //GetAll by Anniversary
//        public IEnumerable<Person> GetAllByAnniversary(DateTime datetime)
//        {
//            DateTime date = new DateTime(datetime.Year, datetime.Month, datetime.Day);
//            return _db.People.Where(p => p.HiringDate.Month == date.Month && p.HiringDate.Day == date.Day);
//        }

//        //GetAll by Anniversary Async
//        public async Task<IEnumerable<Person>> GetAllByAnniversaryAsync(DateTime datetime)
//        {
//            throw new NotImplementedException();
//            //return await _db.People.Where(p => p.HiringDate.Equals(datetime.Month) && p.HiringDate.Equals(datetime.Day)).ToListAsync();
//        }
//        public IEnumerable<Person> GetAllByEmail(string email)
//        {
//            return _db.People.Where(p => p.Email == email); ;
//        }

//        public Task<IEnumerable<Person>> GetAllByEmailAsync(string email)
//        {
//            throw new NotImplementedException();
//        }

//        //-----------------------------------------------------------------------------
//        /* Get / Read                                                                */
//        //-----------------------------------------------------------------------------

//        public Person? Get(int id)
//        {
//            return _db.People.FirstOrDefault(p => p.Id == id);
//        }

//        public async Task<Person?> GetAsync(int id)
//        {
//            return await _db.People.FirstOrDefaultAsync(p => p.Id == id);
//        }

//        public Person? GetByEmail(string email)
//        {
//            return _db.People.FirstOrDefault(p => p.Email == email);
//        }

//        public async Task<Person?> GetByEmailAsync(string email)
//        {
//            return await _db.People.FirstOrDefaultAsync(p => p.Email == email);
//        }

//        //-----------------------------------------------------------------------------
//        /* Create / Post                                                             */
//        //-----------------------------------------------------------------------------

//        public bool Create(Person entity)
//        {
//            _db.People.Add(entity);
//            return _db.SaveChanges() != 0; //returns true if numb of effected rows is not 0
           
//        }

//        public async Task<bool> CreateAsync(Person entity)
//        {
//            _db.People.Add(entity);
//            return await _db.SaveChangesAsync() != 0; //returns true if numb of effected rows is not 0
//        }

//        //-----------------------------------------------------------------------------
//        /* Update / Put                                                              */
//        //-----------------------------------------------------------------------------

//        public bool Update(Person entity)
//        {
//            _db.People.Update(entity);
//            return _db.SaveChanges() != 0;
//        }

//        public async Task<bool> UpdateAsync(Person entity)
//        {
//            return await _db.SaveChangesAsync() != 0; //returns true if numb of effected rows is not 0
//        }

//        //-----------------------------------------------------------------------------
//        /* Delete / Remove                                                           */
//        //-----------------------------------------------------------------------------

//        public bool Delete(int id)
//        {
//            _db.People.Remove(Get(id));
//            return _db.SaveChanges() != 0; //returns true if numb of effected rows is not 0
//        }

//        public async Task<bool> DeleteAsync(int id)
//        {
//            _db.People.Remove(await GetAsync(id));
//            return await _db.SaveChangesAsync() != 0; //returns true if numb of effected rows is not 0
//        }
//    }
//}
