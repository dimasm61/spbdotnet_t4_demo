
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Polly.CircuitBreaker;

namespace ExtAssemblyWcf_48
{
    public partial class MyWcfServiceWrapper
    {
        /// <summary>Получения списка сообщений.</summary> 
        public List<string> GetMessagePage(int take, int skip, string textFilter, int? mmsi)
        {
            if (LogInformationEnabled) _logger.Information("{Method} start", nameof(GetMessagePage));
            Stopwatch sw = null;
            if(LogVerboseEnabled || LogDebugEnabled)
                sw = Stopwatch.StartNew();
            try
            {
                if (LogVerboseEnabled) 
                    _logger.Verbose($"{{Method}} args: "
                    + $"take:{take}, "
                    + $"skip:{skip}, "
                    + $"textFilter:{textFilter}, "
                    + $"mmsi:{mmsi}, "
                    , nameof(GetMessagePage));

                return _policy.Execute(() => 
                    {
                        using (var db = new DbContext()) 
                        {
                            return _impl.GetMessagePage(db, take, skip, textFilter, mmsi);
                        }
                    });
            }
            catch(BrokenCircuitException bcex)
            {
                _logger.Warning($"{{Method}} {nameof(BrokenCircuitException)}, return empty", nameof(GetMessagePage));
                return new List<string>();
            }
            catch(Exception ex)
            {
                _logger.Error(ex, nameof(GetMessagePage));
                return new List<string>();
            }
            finally
            {
                if(LogVerboseEnabled || LogDebugEnabled) 
                {
                    sw.Stop();
                    _logger.Debug("{Method} finish, {Duration} ms", nameof(GetMessagePage), sw.ElapsedMilliseconds);
                }
            }
        }
        /// <summary>Получения списка сообщений из архива</summary> 
        public List<string> GetMessageArchivePage(int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi)
        {
            if (LogInformationEnabled) _logger.Information("{Method} start", nameof(GetMessageArchivePage));
            Stopwatch sw = null;
            if(LogVerboseEnabled || LogDebugEnabled)
                sw = Stopwatch.StartNew();
            try
            {
                if (LogVerboseEnabled) 
                    _logger.Verbose($"{{Method}} args: "
                    + $"take:{take}, "
                    + $"skip:{skip}, "
                    + $"textFilter:{textFilter}, "
                    + $"dateFrom:{dateFrom}, "
                    + $"dateTo:{dateTo}, "
                    + $"mmsi:{mmsi}, "
                    , nameof(GetMessageArchivePage));

                return _policy.Execute(() => 
                    {
                        using (var db = new DbContext()) 
                        {
                            return _impl.GetMessageArchivePage(db, take, skip, textFilter, dateFrom, dateTo, mmsi);
                        }
                    });
            }
            catch(BrokenCircuitException bcex)
            {
                _logger.Warning($"{{Method}} {nameof(BrokenCircuitException)}, return empty", nameof(GetMessageArchivePage));
                return new List<string>();
            }
            catch(Exception ex)
            {
                _logger.Error(ex, nameof(GetMessageArchivePage));
                return new List<string>();
            }
            finally
            {
                if(LogVerboseEnabled || LogDebugEnabled) 
                {
                    sw.Stop();
                    _logger.Debug("{Method} finish, {Duration} ms", nameof(GetMessageArchivePage), sw.ElapsedMilliseconds);
                }
            }
        }
    } 
}