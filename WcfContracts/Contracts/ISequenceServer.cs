using System;
using System.ServiceModel;

namespace WcfContracts.Contracts
{
    [ServiceContract]
    public interface ISequenceServer
    {
        [OperationContract]
        void Reset();
        [OperationContract]
        Int32 Next();
        [OperationContract]
        Int32 Current();
    }
}
