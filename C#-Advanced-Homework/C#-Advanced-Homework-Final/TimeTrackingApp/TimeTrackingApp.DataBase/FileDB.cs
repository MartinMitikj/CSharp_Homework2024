using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.DataAccess
{
    public class FileDB<T> : IGenericDB<T> where T : BaseEntity
    {
        private string _dbDirectory;
        private string _dbFile;
        private int _id;

        public FileDB()
        {
            _dbDirectory = @"..\..\..\Db";
            _dbFile = _dbDirectory + $@"\{typeof(T).Name}s.json";
            _id = 0;
            if (!Directory.Exists(_dbDirectory))
            {
                Directory.CreateDirectory(_dbDirectory);
            }
            if (!File.Exists(_dbFile))
            {
                File.Create(_dbFile).Close();
            }
        }

        public void Write(string path, List<T> data)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(JsonConvert.SerializeObject(data));
            }
        }
        public List<T> Read()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_dbFile))
                {
                    string data = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading database: " + ex.Message);
                return new List<T>();
            }
        }

        public int Add(T entity)
        {
            List<T> dbEntities = GetAll();
            if (dbEntities == null)
            {
                dbEntities = new List<T>();
                _id = 1;
            }
            if (dbEntities.Count == 0)
            {
                _id = 1;
            }
            else
            {
                _id = dbEntities.Count + 1;
            }
            entity.Id = _id;
            dbEntities.Add(entity);
            Write(_dbFile, dbEntities);
            return entity.Id;
        }

        public List<T> GetAll()
        {
            using (StreamReader sr = new StreamReader(_dbFile))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
        }

        public T GetById(int id)
        {
            List<T> dbEntities = GetAll();
            return dbEntities.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveById(int id)
        {
            List<T> dbEntities = GetAll();
            T entityDb = dbEntities.FirstOrDefault(x => x.Id == id);
            if (entityDb == null)
            {
                throw new Exception($"The entity with id {id} does not exists!");
            }
            dbEntities.Remove(entityDb);
            Write(_dbFile, dbEntities);
        }

        public bool Update(T entity)
        {
            List<T> dbEntities = GetAll();
            T entityDb = dbEntities.FirstOrDefault(x => x.Id == entity.Id);
            if (entityDb == null)
            {
                throw new Exception($"The entity with id {entity.Id} does not exists!");
            }
            dbEntities[dbEntities.IndexOf(entityDb)] = entity;
            Write(_dbFile, dbEntities);
            return true;
        }
    }
}


