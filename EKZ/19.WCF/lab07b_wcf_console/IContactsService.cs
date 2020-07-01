using lab07c_wcf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace lab07b_wcf_console
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IContactsService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IContactsService
    {
        [OperationContract]
        List<Telephone> GetDict();
        [OperationContract]
        string GetAll();
        [OperationContract]
        string AddDict(string surname, int number);
        [OperationContract]
        string UpdDict(int id, string surname, int number);
        [OperationContract]
        string DelDict(int id);
    }
}
