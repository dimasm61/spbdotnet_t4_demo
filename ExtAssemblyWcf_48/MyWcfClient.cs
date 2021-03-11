using Polly;
using System;
using System.Data.SqlClient;

namespace ExtAssemblyWcf_48
{
    public partial class MyWcfClient: System.ServiceModel.ClientBase<IMyWcfService>, IMyWcfService
    {
        private Policy _policy;

        public MyWcfClient()
        {
            _policy = Policy
                .Handle<System.TimeoutException>()
                .CircuitBreaker(10, TimeSpan.FromSeconds(60));
        }
    }
}
