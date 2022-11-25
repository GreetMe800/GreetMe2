using GreetMe_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Interface
{
    public interface IPersonRepository : IAsyncRepository<Person>
    {
        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //GetAll Birthdays by Date
        Task<IEnumerable<Person>> GetAllBirthdays(DateOnly date);

        //GetAll Anniversarys by Date
        Task<IEnumerable<Person>> GetAllAnniversarys(DateOnly date);

        //GetAll Birthdays Today
        Task<IEnumerable<Person>> GetAllBirthdaysToday();

        //GetAll Anniversarys Today
        Task<IEnumerable<Person>> GetAllAnniversarysToday();

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Get by Email
        Task<Person?> GetByEmail(string email);

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------



        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

    }
}
