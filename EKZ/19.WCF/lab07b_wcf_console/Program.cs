using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace lab07b_wcf_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/hello");
            //var host = new ServiceHost(typeof(ContactsService));
            using (ServiceHost host = new ServiceHost(typeof(ContactsService)))
            {
                host.Open();

                foreach (var item in host.Description.Endpoints)
                {
                    Console.WriteLine(item.ListenUri);
                }
                Console.WriteLine("The service is ready at {0}", host.Description.Endpoints);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
