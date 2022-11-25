using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Interface
{
    public interface IAsyncRepository<T> where T : class
    {
        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //GetAll
        public Task<IEnumerable<T>> GetAll();

        //Get
        public Task<T?> Get(int id);

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public Task<T> Create(T entity);

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        public Task<T> Update(T entity);

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        public Task<bool> Delete(int id);
    }
}
