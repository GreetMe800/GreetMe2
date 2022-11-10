using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using GreetMe_DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GreetMe_Test.RepositoryTest
{
    public class MenuRepositoryTest
    {
        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        /* Get Object Test */

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        /* Create Object Async Test */
        //TODO

        /* Create Object, with object return */
        [Theory]
        [InlineData("Dagens Menu", "10-20-2011", null, "kodboller i karry")]
        [InlineData("Dagens Menu2", "11-20-2011", null, "kodboller i tomatsuppe")]
        [InlineData("Dagens Menu3", "15-20-2011", "19-20-2011", "kodboller i sovs")]
        [InlineData("Dagens Menu3", "20-20-2011", "25-20-2011", "kodboller i sovs")]
        public void CreateMenu_Successfull_object_return(string menuName, DateTime startDate, DateTime endDate, string desription)
        {
            //Arrange
            MenuRepository menuRepository = new MenuRepository();
            Menu expected = new Menu()
            {
                MenuName = menuName,
                StartDate = startDate,
                EndDate = endDate,
                Description = desription
            };

            //Act
            Menu actual = menuRepository.Create(expected);

            //Assert
            Assert.NotNull(actual);
            Assert.Equal(expected.MenuName, actual.MenuName);
            Assert.Equal(expected.StartDate, actual.StartDate);
            Assert.Equal(expected.EndDate, actual.EndDate);
            Assert.Equal(expected.Description, actual.Description);
        }
        
        /* Create Object Test - Expected Fail */

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        //todo

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        //todo
    }
}
