using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.DataAccess
{
    public interface IGenericDB<T> where T : BaseEntity
    {
        int Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        void RemoveById(int id);
        bool Update(T entity);
    }
}
