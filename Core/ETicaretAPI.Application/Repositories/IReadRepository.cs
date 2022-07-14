using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true); //IQueryable kullan!(Daha optimize bir yöntem)
                                //List veya IEnumerable kullanırsan memory üzerinde işlem yapar.
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true); //bool olmasının sebebi o şarta uyan veriler true döner ve getirilir.
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}
