using System;

namespace MVC_contrl_23
{
    public class CDI
    {
        private string txt = "Empty";
        public CDI()
        {
            Console.WriteLine("CDI: коструктор");
        }
        public string Set(string s)
        {
            Console.WriteLine(this.txt = s);
            return this.txt;
        }
        public string Get()
        {
            Console.WriteLine(this.txt);
            return this.txt;
        }
    }
}