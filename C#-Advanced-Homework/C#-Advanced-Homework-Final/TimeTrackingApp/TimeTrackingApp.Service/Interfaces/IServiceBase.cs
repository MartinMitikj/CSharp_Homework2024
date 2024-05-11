using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Service.Interfaces
{
    public interface IServiceBase<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        bool Update(T entity);
        void Remove(int id);
    }
}
