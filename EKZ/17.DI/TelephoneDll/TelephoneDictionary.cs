using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TelephoneDll
{
    public class TelephoneDictionary : IPhoneDictionary
    {
        private List<Telephone> telephones = new List<Telephone>();

        private List<Telephone> Telephones { get => telephones; set => telephones = value; }

        public TelephoneDictionary()
        {

        }

        public List<Telephone> selectAll()
        {
            string jsonString = File.ReadAllText("D:\\Subject\\ПИС\\Lab\\Lab6json\\Lab3new\\App_Data\\numbers.json");
            this.telephones = JsonConvert.DeserializeObject<List<Telephone>>(jsonString).ToList();
            return telephones.OrderBy(u => u.surname).ToList();
        }
    }
}
