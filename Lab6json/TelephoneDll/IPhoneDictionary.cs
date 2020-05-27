using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDll
{
    public interface IPhoneDictionary
    {
        void insert(string surname, int number);
        List<Telephone> selectAll();
        void update(int id, string surname, int number);
        void delete(int id);
        void saveChange(List<Telephone> telephones);
    }
}
