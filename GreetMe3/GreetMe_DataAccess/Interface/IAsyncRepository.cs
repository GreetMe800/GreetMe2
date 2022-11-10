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

        //Get All
        public Task<IEnumerable<T>> GetAllAsync();

        //Get
        public Task<T?> GetAsync(int id);

        //-----------------------------------------------------------------------------
        /* Create / Post                                                             */
        //-----------------------------------------------------------------------------

        //Create
        public Task<T> CreateAsync(T entity);

        //-----------------------------------------------------------------------------
        /* Update / Put                                                              */
        //-----------------------------------------------------------------------------

        public Task<T> UpdateAsync(T entity);

        //-----------------------------------------------------------------------------
        /* Delete / Remove                                                           */
        //-----------------------------------------------------------------------------

        public Task<bool> DeleteAsync(int id);
    }
}
