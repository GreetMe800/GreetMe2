using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public PersonDto()
        {

        }


        public PersonDto(int id, string fulleName, DateTime dateOfBirth, DateTime hiringDate)
        {
            HiringDate = new DateTime(HiringDate.Year, HiringDate.Month, HiringDate.Day);
            DateOfBirth = new DateTime(DateOfBirth.Year, DateOfBirth.Month, DateOfBirth.Day);

            Id = id;
            FullName = fulleName;
            DateOfBirth = dateOfBirth;
            HiringDate = hiringDate;
        }

        public PersonDto(string fulleName, DateTime dateOfBirth, DateTime hiringDate)
        {
            HiringDate = new DateTime(HiringDate.Year, HiringDate.Month, HiringDate.Day);
            DateOfBirth = new DateTime(DateOfBirth.Year, DateOfBirth.Month, DateOfBirth.Day);

            FullName = fulleName;
            DateOfBirth = dateOfBirth;
            HiringDate = hiringDate;
        }
    }

    
}
