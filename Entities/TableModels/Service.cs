using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class Service : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string IconName { get; set; }
        public string Description { get; set; }
    }
}
