using Bussiness.Abstract;
using Core.Results;
using DataAccess.Entities.Concrete;
using DataAccess.Repositories.IRepositories;

namespace Bussiness.Concrete
{
    public class DonationService : IDonationService
    {
        private readonly IDonationRepository _donationRepository;

        public DonationService(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository;
        }

        public IResult Add(Donation donation)
        {
            _donationRepository.Add(donation);
            return new SuccessResult("");
        }

        public IResult Delete(Donation donation)
        {

            _donationRepository.Delete(donation);
            return new SuccessResult("");
        }

        public IDataResult<List<Donation>> GetAll()
        {
            return new SuccessDataResult<List<Donation>>(_donationRepository.GetAll(), "");
        }

        public IDataResult<Donation> GetById(int id)
        {
            return new SuccessDataResult<Donation>(_donationRepository.Get(x => x.Id == id));
        }

        public IResult Update(Donation donation)
        {
            _donationRepository.Uptade(donation);
            return new SuccessResult("");
        }
    }
}
