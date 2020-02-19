using System;
using System.ServiceModel;

namespace WcfContracts.Contracts
{
    [ServiceContract(Namespace = "vadikorzh.com.com.com")]
    public interface ISequenceServer
    {
        [OperationContract()]
        void Reset();
        [OperationContract]
        Int32 Next();
        [OperationContract]
        Int32 Current();
    }
}
