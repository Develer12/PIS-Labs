using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TelephoneDll
{
    public class TelephoneDictionary : IPhoneDictionary
    {
        PhoneContext db = new PhoneContext();

        public List<Telephone> selectAll()
        {
            var telephones = db.Telephone;
            return telephones.OrderBy(t => t.surname).ToList();
        }

        public void insert(string surname, string number)
        {
            if (surname != null && number != null)
            {
                Telephone tel = new Telephone();
                tel.number = number;
                tel.surname = surname;

                db.Telephone.Add(tel);
                db.SaveChanges();
            }
        }

        public void update(int? id, string surname, string number)
        {
            if (id != null && surname != null && number != null)
            {
                Telephone tel = db.Telephone.Find(id);
                if (tel != null)
                {
                    tel.surname = surname;
                    tel.number = number;
                    db.Entry(tel).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void delete(int? id)
        {
            if (id != null)
            {
                Telephone tel = db.Telephone.Find(id);
                if (tel != null)
                {
                    db.Telephone.Remove(tel);
                    db.SaveChanges();
                }
            }
        }
    }
}
