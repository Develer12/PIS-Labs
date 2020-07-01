using Domain.Models;
using Domain.Services.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Domain.Repository
{
    public class CatalogRepository : ICatalogRepository
    {
        private SortedSet<Record> _database = new SortedSet<Record>();
        private static string _path;

        public CatalogRepository()
        {
            _path = HttpContext.Current.Server.MapPath("~/catalog.json");
            _database = GetDataFromJson(_path);
        }

        public void Add(Record record)
        {
            if (!(record is Record))
            {
                throw new ArgumentException(nameof(record));
            }

            record.Id = GetId();
            _database.Add(record);
            SaveChanges(_path);
        }

        public void Delete(int id)
        {
            var record = _database.FirstOrDefault(x => x.Id == id);
            _database.Remove(record);

            SaveChanges(_path);
        }

        public Record Get(int id)
        {
            return _database.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Record> GetAll()
        {
            return _database.ToArray();
        }

        public void Update(Record record)
        {
            if (!(record is Record))
            {
                throw new ArgumentException(nameof(record));
            }

            var upd = Get(record.Id);
            upd.FullName = record.FullName;
            upd.PhoneNumber = record.PhoneNumber;

            SaveChanges(_path);
        }

        private int GetId()
        {
            int id = 0;
            if (_database != null && _database.Any())
            {
                id = _database.Max(i => i.Id);
                ++id;
            }
            return id;
        }

        private SortedSet<Record> GetDataFromJson(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            SortedSet<Record> models;
            using (var fs = File.OpenText(path))
            {
                var formatter = new JsonSerializer();
                models = (SortedSet<Record>)formatter.Deserialize(fs, typeof(SortedSet<Record>));
            }

            return models;
        }

        private void SaveChanges(string path)
        {
            using (var file = File.CreateText(path))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, _database);
            }

        }
    }
}
