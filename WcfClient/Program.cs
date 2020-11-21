using System;
using System.ServiceModel;

namespace WcfClient
{
    class Client
    {
        static void Main()
        {
            ServiceClient client = new ServiceClient();

            Console.Out.WriteLine(client.ToUpperCase("test message"));

            client.Close();
        }
    }
}
