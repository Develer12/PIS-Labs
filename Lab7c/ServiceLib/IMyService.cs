using System.ServiceModel;
using System.Collections.Generic;

namespace ServiceLib
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        List<Models.Telephone> GetDict();
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
