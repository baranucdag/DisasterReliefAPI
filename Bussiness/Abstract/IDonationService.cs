using Core.Results;
using DataAccess.Entities.Concrete;

namespace Bussiness.Abstract
{
    public interface IDonationService
    {
        IResult Add(Donation donation);
        IResult Delete(Donation donation);
        IResult Update(Donation donation);
        IDataResult<List<Donation>> GetAll();
        IDataResult<Donation> GetById(int id);

    }
}
