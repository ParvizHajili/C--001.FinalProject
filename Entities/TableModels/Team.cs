using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class Team : BaseEntity, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public int PoritionId { get; set; }
        public Position Position { get; set; }
    }
}
