using Core.Results;
using DisasterRelief.DataAccess.Entities.Concrete;

namespace DisasterRelief.Bussiness.Abstract
{
    public interface IDemandService
    {
        IResult Add(Demand demand);
        IResult Delete(Demand demand);
        IResult Update(Demand demand);
        IDataResult<List<Demand>> GetAll();
        IDataResult<Demand> GetById(int id);
    }
}
