using Bussiness.Abstract;
using Core.Results;
using DataAccess.Entities.Concrete;
using DataAccess.Repositories.IRepositories;

namespace Bussiness.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IResult Add(User user)
        {
            _userRepository.Add(user);
            return new SuccessResult("");
        }

        public IResult Delete(User user)
        {

            _userRepository.Delete(user);
            return new SuccessResult("");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userRepository.GetAll(), "");
        }

        public IDataResult<User> GetByUserId(int id)
        {
            return new SuccessDataResult<User>(_userRepository.Get(x => x.Id == id));
        }

        public IResult Update(User user)
        {
            _userRepository.Uptade(user);
            return new SuccessResult("");
        }

        public User GetByMail(string email)
        {
            return _userRepository.Get(x => x.Email == email);
        }
    }
}
