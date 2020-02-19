using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfContracts.Contracts;

namespace SequenceServiceLib.Contracts
{
    public class SimpleServer : ISequenceServer
    {
        public int Current()
        {
            return StaticFields.SimpleServerCounter;
        }

        public int Next()
        {
            return ++StaticFields.SimpleServerCounter;
        }

        public void Reset()
        {
            StaticFields.SimpleServerCounter = 0;
        }
    }
}
