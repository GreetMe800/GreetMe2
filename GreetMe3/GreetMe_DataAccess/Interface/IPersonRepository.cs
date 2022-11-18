using GreetMe_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Interface
{
    public interface IPersonRepository : IRepository<Person>, IAsyncRepository<Person>
    {
        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //GetAll by Birthday
        IEnumerable<Person> GetAllByBirthday(DateTime datetime);

        //GetAll by Birthday Async
        Task<IEnumerable<Person>> GetAllByBirthdayAsync(DateTime datetime);

        //GetAll by Birthday
        IEnumerable<Person> GetAllByAnniversary(DateTime datetime);

        //GetAll by Birthday Async
        Task<IEnumerable<Person>> GetAllByAnniversaryAsync(DateTime datetime);



        //Get by Email
        Person? GetByEmail(string email);

        //Get by Email Async
        Task<Person?> GetByEmailAsync(string email);

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------



        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------



        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

    }
}
