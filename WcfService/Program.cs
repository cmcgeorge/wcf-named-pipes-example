using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract(Namespace="http://WcfService")]
    public interface IService
    {
        [OperationContract]
        [FaultContract(typeof(NullFault))]
        string ToUpperCase(string text);
    }

    [DataContract(Namespace="http://WcfService")]
    public class NullFault
    {
        [DataMember]
        public string Message { get; set; }
    }

    public class Service : IService
    {
        public string ToUpperCase(string text)
        {
            if (text == null)
            {
                throw new FaultException<NullFault>(new NullFault() { Message = "Value cannot be null."});
            }

            return text.ToUpper();
        }

        public static void Main()
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(Service)))
            {
                serviceHost.Open();

                Console.WriteLine("The service is running.  Press enter to exit.");
                Console.ReadLine();
            }
        }
    }
}
