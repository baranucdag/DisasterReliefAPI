using Core.DataAccess.EntityFramework;
using DataAccess.Context;
using DisasterRelief.DataAccess.Entities.Concrete;
using DisasterRelief.DataAccess.Repositories.IRepositories;

namespace DisasterRelief.DataAccess.Repositories.Repositories
{
    public class DemandRepository : EFEntityRepositoryBase<Demand,DataContext>,IDemandRepository
    {
    }
}
