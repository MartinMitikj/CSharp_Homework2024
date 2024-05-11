using TimeTrackingApp.DataAccess;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Service.Interfaces;

namespace TimeTrackingApp.Service
{
    public class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        private IGenericDB<T> _db;

        public ServiceBase()
        {
            _db = new FileDB<T>();
        }

        public List<T> GetAll()
        {
            return _db.GetAll();
        }

        public T GetById(int id)
        {
            return _db.GetById(id);
        }

        public bool Update(T entity)
        {
            _db.Update(entity);
            return true;
        }

        public void Remove(int id)
        {
            _db.RemoveById(id);
        }
    }
}
