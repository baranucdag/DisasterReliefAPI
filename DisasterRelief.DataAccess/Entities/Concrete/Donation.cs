using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concrete
{
    public class Donation : IEntity
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Unit { get; set; }
        public string Address { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
