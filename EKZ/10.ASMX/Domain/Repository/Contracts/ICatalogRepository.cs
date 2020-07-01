using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services.Contracts
{
    public interface ICatalogRepository
    {
        IEnumerable<Record> GetAll();
        Record Get(int id);
        void Add(Record record);
        void Update(Record record);
        void Delete(int id);

    }
}
