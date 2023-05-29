using Core.DataAccess.EntityFramework;
using DataAccess.Context;
using DataAccess.Entities.Concrete;
using DataAccess.Repositories.IRepositories;

namespace DataAccess.Repositories.Repositories
{
    public class DonationRepository : EFEntityRepositoryBase<Donation,DataContext>, IDonationRepository
    {
    }
}
