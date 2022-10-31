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

        //GetAll by Email
        IEnumerable<Person> GetAllByEmail(string email);

        //GetAll by Email Async
        Task<IEnumerable<Person>> GetAllByEmailAsync(string email);
        //GetBy Email
        public Person? GetByEmail(string email);
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
