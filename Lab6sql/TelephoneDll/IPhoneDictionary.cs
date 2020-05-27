using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDll
{
    public interface IPhoneDictionary
    {
        void insert(string surname, string number);
        List<Telephone> selectAll();
        void update(int? id, string surname, string number);
        void delete(int? id);
    }
}
