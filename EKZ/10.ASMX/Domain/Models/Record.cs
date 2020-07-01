using System;

namespace Domain.Models
{
    public class Record : IComparable<Record>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public int CompareTo(Record other)
        {
            return FullName.CompareTo(other.FullName);
        }
    }
}
