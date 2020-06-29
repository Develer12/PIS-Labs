using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Telephone
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string number { get; set; }
    }

    /*
        use pislab8;
        go
        create table Telephones 
        (
	        id int IDENTITY(1,1),
	        surname nvarchar(30),
	        number nvarchar(30)
        ); 
    */
}
