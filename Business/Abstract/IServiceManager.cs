using Entities.TableModels;

namespace Business.Abstract
{
    public interface IServiceManager
    {
        void Add(Service entity);
        void Update(Service entity);
        void Delete(Service entity);
        List<Service> GetAll();
        Service GetById(int id);
    }

}
