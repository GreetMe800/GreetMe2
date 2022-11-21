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

        //GetAll by Birthday
        Task<IEnumerable<Person>> GetAllByBirthday(DateTime datetime);

        //GetAll by Birthday
        Task<IEnumerable<Person>> GetAllByAnniversary(DateTime datetime);

        //Get by Email Async
        Task<Person?> GetByEmail(string email);

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
