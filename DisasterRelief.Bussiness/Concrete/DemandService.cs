using Core.Results;
using DisasterRelief.Bussiness.Abstract;
using DisasterRelief.DataAccess.Entities.Concrete;
using DisasterRelief.DataAccess.Repositories.IRepositories;

namespace DisasterRelief.Bussiness.Concrete
{
    public class DemandService : IDemandService
    {
        private readonly IDemandRepository _demandRepository;
        public DemandService(IDemandRepository demandRepository)
        {
            _demandRepository = demandRepository;
        }
        public IResult Add(Demand demand)
        {
            _demandRepository.Add(demand);
            return new SuccessResult("");
        }

        public IResult Delete(Demand demand)
        {

            _demandRepository.Delete(demand);
            return new SuccessResult("");
        }

        public IDataResult<List<Demand>> GetAll()
        {
            return new SuccessDataResult<List<Demand>>(_demandRepository.GetAll(), "");
        }

        public IDataResult<Demand> GetById(int id)
        {
            return new SuccessDataResult<Demand>(_demandRepository.Get(x => x.Id == id));
        }

        public IResult Update(Demand demand)
        {
            _demandRepository.Uptade(demand);
            return new SuccessResult("");
        }
    }
}
