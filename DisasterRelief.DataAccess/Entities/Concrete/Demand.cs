using DataAccess.Entities.Abstract;

namespace DisasterRelief.DataAccess.Entities.Concrete
{
    public class Demand : IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string address { get; set; }
    }
}
