using Polly;
using Polly.CircuitBreaker;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtAssemblyWcf_48
{
    public partial class MyWcfServiceWrapper : MyWcfInterface
    {
        private Policy _policy;

        public const int TimeoutExceptionCode = -2;

        private MyWcfServiceImpl _impl;

        public bool LogVerboseEnabled = true;
        public bool LogDebugEnabled = true;
        public bool LogInformationEnabled = true;

        ILogger _logger = Serilog.Log.ForContext("Service", "MyWcfService");

        public MyWcfServiceWrapper(MyWcfServiceImpl impl)
        {
            _impl = impl;

            _policy = Policy
                .Handle<SqlException>(ex => ex.Number == TimeoutExceptionCode)
                .CircuitBreaker(10, TimeSpan.FromMinutes(10));
        }


    }
}
