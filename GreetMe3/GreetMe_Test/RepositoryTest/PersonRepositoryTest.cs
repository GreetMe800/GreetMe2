using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreetMe_DataAccess.Model;
using GreetMe_DataAccess.Repository;
using Xunit;
using Xunit.Sdk;

namespace GreetMe_Test.RepositoryTest
{
    public class PersonRepositoryTest
    {
        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void GetPerson_Successfull(int id)
        {
            //Arrange
            PersonRepository personRepository = new PersonRepository();
            int expected = id;

            //Assert
            Person actual = personRepository.Get(expected);

            //Act
            Assert.NotNull(actual);
            Assert.IsType<Person>(actual);
            Assert.NotNull(actual.FullName);
            Assert.NotNull(actual.DateOfBirth);
            Assert.NotNull(actual.HiringDate);
            Assert.NotNull(actual.Email);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        /* Create Person Test */
        [Theory]
        [InlineData("George", "10-20-2011", "10-20-2011", "George123@hotmail.com")]
        [InlineData("Henrik", "11-21-2011", "11-21-2011", "Henrik123@hotmail.com")]
        [InlineData("Larsen", "12-22-2011", "12-22-2011", "Larsen123@hotmail.com")]
        public void CreatePerson_Successfull(string fullName, DateTime dateOfBirth, DateTime hiringDate, string email)
        {
            //Arrange
            PersonRepository personRepository = new PersonRepository();
            Person person = new Person
            {
                FullName = fullName,
                DateOfBirth = dateOfBirth,
                HiringDate = hiringDate,
                Email = email,
            };

            //Assert
            bool actual = personRepository.Create(person);

            //Act
            Assert.True(actual);

        }

        /* Create Person Async Test */
            //TODO

        /* Create Person, with validation for each antribrute */

        [Theory]
        [InlineData("George", "10-20-2011", "10-20-2011", "George123@hotmail.com")]
        [InlineData("Henrik", "11-21-2011", "11-21-2011", "Henrik123@hotmail.com")]
        [InlineData("Larsen", "12-22-2011", "12-22-2011", "Larsen123@hotmail.com")]
        public void CreatePerson_Successfull2(string fullName, DateTime dateOfBirth, DateTime hiringDate, string email)
        {
            //Assert
            PersonRepository personRepository = new PersonRepository();
            Person expected = new Person
            {
                FullName = fullName,
                DateOfBirth = dateOfBirth,
                HiringDate = hiringDate,
                Email = email,
            };

            //Arrange
            var actual = personRepository.CreateTest(expected);

            //act
            Assert.NotNull(actual);
            Assert.Equal(expected.FullName, actual.FullName);
            Assert.Equal(expected.DateOfBirth, actual.DateOfBirth);
            Assert.Equal(expected.HiringDate, actual.HiringDate);
            Assert.Equal(expected.Email, actual.Email);

        }

        /* Create Person Test - Expected Fail */
        [Theory]
        [InlineData("George", "10-20-2011", "10-20-2011", "George123@hotmail.com")]
        [InlineData("Henrik", "11-21-2011", "11-21-2011", "Henrik123@hotmail.com")]
        [InlineData("Larsen", "12-22-2011", "12-22-2011", "Larsen123@hotmail.com")]

        public void CreatePerson_ThrowsException(string fullName, DateTime dateOfBirth, DateTime hiringDate, string email)
        {
            //Arrange
            PersonRepository personRepository = new PersonRepository();
            Person expected = new Person
            {
                FullName = fullName,
                DateOfBirth = dateOfBirth,
                HiringDate = hiringDate,
                Email = email,
            };

            //Act
            var ex = Record.Exception(() => personRepository.CreateTest(expected));

            //Assert
            Assert.NotNull(ex);
            Assert.IsType<ArgumentException>(ex);

        }

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------
    }
}
