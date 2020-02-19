using SequenceClient.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SequenceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Today we're using a WCF sequence service.");
            using (var serviceProxy = new ServiceReference4.VocabularyServiceClient())
            {
                serviceProxy.AddSynonym("grim", "gloom");
                serviceProxy.AddSynonym("grim", "morose");
                serviceProxy.AddAntonymAttrName("grim", "jovial");

                var wordInfo = serviceProxy.GetWordInfo("grim");

                Console.WriteLine(wordInfo.BaseWord);
                Console.WriteLine("\nSynonyms: \n");
                foreach (var item in wordInfo.Synonyms)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nAntonyms: \n");
                foreach (var item in wordInfo.Antonyms)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void UsingAsyncWcfCalls()
        {
            using (var proxy = new ServiceReference3.SequenceServerClient())
            {
                var result = proxy.BeginCurrent((ar) => { Console.WriteLine("Current = " + proxy.EndCurrent(ar)); }, null);

                while (!result.IsCompleted)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("Waiting for the service response...");
                }
            }
        }
    }
}
