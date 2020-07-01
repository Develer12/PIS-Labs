using lab07c_wcf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace lab07b_wcf_console
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ContactsService" в коде и файле конфигурации.
    public class ContactsService : IContactsService
    {
        TelephoneDictionary telephoneDictionary = new TelephoneDictionary();
        public string GetAll()
        {
            return telephoneDictionary.getAll();
        }

        public List<Telephone> GetDict()
        {
            return telephoneDictionary.selectAll();
        }

        public string AddDict(string surname, int number)
        {
            telephoneDictionary.insert(surname, number);

            return "OK";
        }

        public string UpdDict(int id, string surname, int number)
        {
            return telephoneDictionary.update(id, surname, number);
        }

        public string DelDict(int id)
        {
            return telephoneDictionary.delete(id);
        }
    }
}
