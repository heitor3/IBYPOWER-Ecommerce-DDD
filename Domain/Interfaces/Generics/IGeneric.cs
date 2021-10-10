using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Entity);

        Task Update(T Entity);

        Task Delete(T Entity);

        Task<T> GetEntityById(int Id);

        Task<List<T>> List();

    }
}
