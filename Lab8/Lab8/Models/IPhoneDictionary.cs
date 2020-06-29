using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public interface IPhoneDictionary
    {
        List<Telephone> selectAll();
        Telephone selectById(int id);
        bool insert(string surname, string number);
        bool update(int? id, string surname, string number);
        bool delete(int? id);
    }
}
