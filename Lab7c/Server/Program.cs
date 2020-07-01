using System.ServiceModel;


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServiceLib.MyService));
            host.Open();
            System.Console.WriteLine("WCF started");
            System.Console.ReadKey();
        }
    }
}
