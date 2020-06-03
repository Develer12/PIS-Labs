using System.Collections.Generic;

namespace ServiceLib
{
    public class MyService : IMyService
    {
        Models.TelephoneDictionary telephoneDictionary = new Models.TelephoneDictionary();


        public string GetAll()
        {
            return telephoneDictionary.getAll();
        }

        public List<Models.Telephone> GetDict()
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
            telephoneDictionary.update(id, surname, number);

            return "OK";
        }

        public string DelDict(int id)
        {
            telephoneDictionary.delete(id);

            return "OK";
        }
    }
}
