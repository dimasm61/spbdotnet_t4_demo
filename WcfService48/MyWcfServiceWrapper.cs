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

namespace WcfService48
{
    public partial class MyWcfServiceWrapper: IMyWcfService
    {
        private Policy _policy;

        public const int TimeoutExceptionCode = -2;

        public bool IsTrace => LogVerboseEnabled || LogDebugEnabled;

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

        //private void Log(string methodName, object data)
        //{

        //}

        public List<string> GetMessagePage2(int take, int skip, string textFilter, int? mmsi)
        {
            if (LogInformationEnabled) _logger.Information("{Method} start", nameof(GetMessagePage2));
            Stopwatch sw = null;

            if (IsTrace)
                sw = Stopwatch.StartNew();
            try
            {
                if (LogVerboseEnabled) _logger.Verbose($"{{Method}} args: "
                    + $"take:{take}"
                    + $"take:{skip}"
                    + $"take:{textFilter}"
                    + $"take:{mmsi}"
                    , nameof(GetMessagePage2));

                using (var db = new DbContext())
                {
                    return _policy.Execute(() => _impl.GetMessagePage(db, take, skip, textFilter, mmsi));
                }
            }
            catch (BrokenCircuitException bcex)
            {
                _logger.Warning($"{{Method}} {nameof(BrokenCircuitException)}, return empty", nameof(GetMessagePage2));
                return new List<string>();
            }
            catch (Exception ex)
            {
                if (IsTrace) sw.Stop();

                _logger.Error(ex, nameof(GetMessagePage2));
            }
            finally
            {
                if (IsTrace)
                {
                    sw.Stop();
                    if (LogDebugEnabled) _logger.Debug("{Method} finish, {Duration} ms", nameof(GetMessagePage2), sw.ElapsedMilliseconds);
                }
            }

            return null;
        }
    }
}
