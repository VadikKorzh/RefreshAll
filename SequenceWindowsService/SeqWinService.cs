using SequenceServiceLib.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WcfContracts.Contracts;

namespace SequenceWindowsService
{
    public partial class SeqWinService : ServiceBase
    {
        private ServiceHost _host;

        public SeqWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _host?.Close();

            _host = new ServiceHost(typeof(SimpleServer), new Uri("http://localhost:33556/simmmpple"));
            _host.AddDefaultEndpoints();
            //_host.AddServiceEndpoint(typeof(ISequenceServer), new BasicHttpBinding(), "http://localhost:33344/SimpleSequence");
            _host.Open();
        }

        protected override void OnStop()
        {
            _host?.Close();
        }
    }
}
