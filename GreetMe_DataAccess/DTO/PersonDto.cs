using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreetMe_DataAccess.Model;

namespace GreetMe_DataAccess.DTO
{
    public class PersonDto
    {
        public int Id { get; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HiringDate { get; set; }
        public string Email { get; set; }

        public PersonDto()
        {

        }


        public PersonDto(int id, string fullName, DateTime dateOfBirth, DateTime hiringDate, string email)
        {
            HiringDate = new DateTime(HiringDate.Year, HiringDate.Month, HiringDate.Day);
            DateOfBirth = new DateTime(DateOfBirth.Year, DateOfBirth.Month, DateOfBirth.Day);

            Id = id;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            HiringDate = hiringDate;
            Email = email;
        }

        public PersonDto(string fullName, DateTime dateOfBirth, DateTime hiringDate, string email)
        {
            HiringDate = new DateTime(HiringDate.Year, HiringDate.Month, HiringDate.Day);
            DateOfBirth = new DateTime(DateOfBirth.Year, DateOfBirth.Month, DateOfBirth.Day);

            FullName = fullName;
            DateOfBirth = dateOfBirth;
            HiringDate = hiringDate;
            Email = email;
        }
        public PersonDto(string fullName, DateTime dateOfBirth)
        {
            DateOfBirth = new DateTime(DateOfBirth.Year, DateOfBirth.Month, DateOfBirth.Day);

            FullName = fullName;
            DateOfBirth = dateOfBirth;
        }

    }

    
}
