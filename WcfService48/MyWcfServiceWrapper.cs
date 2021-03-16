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

        public T GetDataWrapper<T>(
              string methodName
            , Func<DbContext,T> act
        ) where T: class, new()
        {
            if (LogInformationEnabled) _logger.Information("{Method} start", methodName);
            Stopwatch sw = null;
            if(IsTrace)
                sw = Stopwatch.StartNew();
            try
            {

                using(var db = new DbContext())
                {
                    return _policy.Execute<T>(() => act?.Invoke(db));
                }
            }
            catch(BrokenCircuitException bcex)
            {
                _logger.Warning($"{{Method}} {nameof(BrokenCircuitException)}, return empty", methodName);
                return new T();
            }
            catch(Exception ex)
            {
                if(IsTrace) sw.Stop();

                _logger.Error(ex, nameof(GetMessagePage));
            }
            finally
            {
                if(IsTrace) 
                {
                    sw.Stop();
                    if (LogDebugEnabled) _logger.Debug("{Method} finish, {Duration} ms", methodName, sw.ElapsedMilliseconds);
                }
            }

            return null;
        }

        public List<string> GetMessagePage2(int take, int skip, string textFilter, int? mmsi)
        {
            var act = new Func<DbContext, List<string>>((db) => _impl.GetMessagePage(db, take, skip, textFilter, mmsi));

            return GetDataWrapper(nameof(GetMessagePage2), act);
        }
    }
}
