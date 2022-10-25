﻿using GreetMe_DataAccess.DTO;
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
            var persons = _db.People;
            return persons.ToList();
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
            DateTime date = new DateTime(datetime.Year, datetime.Month, datetime.Day);
            return _db.People.Where(p => p.DateOfBirth.Month == date.Month && p.DateOfBirth.Day == date.Day);
        }

        //GetAll by Birthday Async
        public async Task<IEnumerable<Person>> GetAllByBirthdayAsync(DateTime datetime)
        {
            throw new NotImplementedException();
            //return await _db.People.Where(p => p.DateOfBirth.Equals(datetime.Month) && p.DateOfBirth.Equals(datetime.Day)).ToListAsync();
        }

        //GetAll by Anniversary
        public IEnumerable<Person> GetAllByAnniversary(DateTime datetime)
        {
            DateTime date = new DateTime(datetime.Year, datetime.Month, datetime.Day);
            return _db.People.Where(p => p.HiringDate.Month == date.Month && p.HiringDate.Day == date.Day);
        }

        //GetAll by Anniversary Async
        public async Task<IEnumerable<Person>> GetAllByAnniversaryAsync(DateTime datetime)
        {
            throw new NotImplementedException();
            //return await _db.People.Where(p => p.HiringDate.Equals(datetime.Month) && p.HiringDate.Equals(datetime.Day)).ToListAsync();
        }

        //GetAll by Email
        public IEnumerable<Person> GetAllByEmail(string email)
        {
            return _db.People.Where(p => p.Email.Equals(email)).ToList();
        }

        //GetAll by Email Async
        public async Task<IEnumerable<Person>> GetAllByEmailAsync(string email)
        {
            return await _db.People.Where(p => p.Email.Equals(email)).ToListAsync();
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

        //Getby Email
        public Person? GetByEmail(string email)
        {
            return _db.People.FirstOrDefault(p => p.Email == email);
        }

        //Getby Email Async
        public async Task<Person?> GetByEmailAsync(string email)
        {
            return await _db.People.FirstOrDefaultAsync(p => p.Email == email);
        }

        //Getby Email with dep
        //TODO

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        //Create
        public Person? Create(Person entity)
        {
            entity.HiringDate = new DateTime(entity.HiringDate.Year, entity.HiringDate.Month, entity.HiringDate.Day); 
            entity.DateOfBirth = new DateTime(entity.DateOfBirth.Year, entity.DateOfBirth.Month, entity.DateOfBirth.Day);
            _db.People.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        //Create Async
        public async Task<Person?> CreateAsync(Person entity)
        {
            entity.HiringDate = new DateTime(entity.HiringDate.Year, entity.HiringDate.Month, entity.HiringDate.Day);
            entity.DateOfBirth = new DateTime(entity.DateOfBirth.Year, entity.DateOfBirth.Month, entity.DateOfBirth.Day);
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
            entity.HiringDate = new DateTime(entity.HiringDate.Year, entity.HiringDate.Month, entity.HiringDate.Day);
            entity.DateOfBirth = new DateTime(entity.DateOfBirth.Year, entity.DateOfBirth.Month, entity.DateOfBirth.Day);
            _db.People.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        //Update Async
        public async Task<Person?> UpdateAsync(Person entity)
        {
            entity.HiringDate = new DateTime(entity.HiringDate.Year, entity.HiringDate.Month, entity.HiringDate.Day);
            entity.DateOfBirth = new DateTime(entity.DateOfBirth.Year, entity.DateOfBirth.Month, entity.DateOfBirth.Day);
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
