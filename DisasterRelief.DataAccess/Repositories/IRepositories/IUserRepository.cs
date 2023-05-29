using Core.DataAccess;
using DataAccess.Entities.Concrete;

namespace DataAccess.Repositories.IRepositories
{
    public interface IUserRepository : IEntityRepository<User>
    {
    }
}
