using Polly;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ExtAssemblyWcf_48
{
    public partial class MyWcfClient: System.ServiceModel.ClientBase<MyWcfInterface>, MyWcfInterface
    {
        private Policy _policy;

        public MyWcfClient()
        {
            _policy = Policy
                .Handle<System.TimeoutException>()
                .CircuitBreaker(10, TimeSpan.FromSeconds(60));
        }
        
        
        public List<string> GetMessagePageWithRetry(int take, int skip, string textFilter, int? mmsi)
        {
            return _policy.Execute(() => base.Channel.GetMessagePage(take, skip, textFilter, mmsi));
        }
    }
}
