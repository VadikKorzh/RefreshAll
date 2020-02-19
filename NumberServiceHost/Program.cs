using SequenceServiceLib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using VocabularyServiceLib.Contracts;
using WcfContracts.Contracts;

namespace NumberServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(SimpleVocabularyService)))
            {
                host.Open();
                Console.WriteLine("Running Simple WCF service...");
                Console.WriteLine();
                DisplayHostInfo(host);
                Console.ReadLine();
            }
        }

        static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine("*** HOST ***");
            Console.WriteLine(host.Description.Name);
            Console.WriteLine(host.Description.ConfigurationName);
            Console.WriteLine(host.State);
            Console.WriteLine();

            Console.WriteLine("--- Endpoints ---");
            foreach (var endpoint in host.Description.Endpoints)
            {
                Console.WriteLine(endpoint.Address.Uri);
            }
            Console.WriteLine();

            Console.WriteLine("--- Base Addresses ---");
            foreach (var baseAddress in host.BaseAddresses)
            {
                Console.WriteLine(baseAddress);
            }
        }
    }
}
