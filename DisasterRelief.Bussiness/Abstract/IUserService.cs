using Core.Results;
using DataAccess.Entities.Concrete;

namespace Bussiness.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int id);
        User GetByMail(string email);
    }
}
