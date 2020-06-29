using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class PhoneContext : DbContext, IPhoneDictionary
    {
        public DbSet<Telephone> Telephones { get; set; }

        public PhoneContext(DbContextOptions<PhoneContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }



        public List<Telephone> selectAll()
        {
            var telephones = this.Telephones;
            return telephones.OrderBy(t => t.surname).ToList();
        }

        public Telephone selectById(int id)
        {
            Telephone tel = this.Telephones.Find(id);
            return tel == null? null : tel;
        }

        public bool insert(string surname, string number)
        {
            if (surname != null && number != null)
            {
                Telephone tel = new Telephone();
                tel.number = number;
                tel.surname = surname;

                this.Telephones.Add(tel);
                this.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool update(int? id, string surname, string number)
        {
            if (id != null && surname != null && number != null)
            {
                var telephones = this.Telephones;

                Telephone tel = this.Telephones.Find(id);
                if (tel != null)
                {
                    tel.surname = surname;
                    tel.number = number;
                    this.Entry(tel).State = EntityState.Modified;
                    this.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool delete(int? id)
        {
            if (id != null)
            {
                Telephone tel = this.Telephones.Find(id);
                if (tel != null)
                {
                    this.Telephones.Remove(tel);
                    this.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}