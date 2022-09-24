

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Polly.CircuitBreaker;

namespace WcfService48
{
    public partial class MyWcfService
    {
        /// <summary>Получение списка сообщений.</summary>
        public List<string> GetMessagePage (int take, int skip, string textFilter, int? mmsi)
        {
            if (LogInformationEnabled) _logger.Information("{Method} start", nameof(GetMessagePage));
            Stopwatch sw = null;
            if(IsTrace)
                sw = Stopwatch.StartNew();
            try
            {
                if (LogVerboseEnabled) _logger.Verbose($"{{Method}} args: "
                    + $"take:{take}, "
                    + $"skip:{skip}, "
                    + $"textFilter:{textFilter}, "
                    + $"mmsi:{mmsi}, "
                    , nameof(GetMessagePage));

                using(var db = new DbContext())
                {
                    return _policy.Execute(() => _impl.GetMessagePage(db, take, skip, textFilter, mmsi));
                }
            }
            catch(BrokenCircuitException bcex)
            {
                _logger.Warning($"{{Method}} {nameof(BrokenCircuitException)}, return empty", nameof(GetMessagePage));
                return new List<string>();
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
                    if (LogDebugEnabled) _logger.Debug("{Method} finish, {Duration} ms", nameof(GetMessagePage), sw.ElapsedMilliseconds);
                }
            }

            return null;
        }
        /// <summary>Получение списка сообщений из архива</summary>
        public List<string> GetMessageArchivePage (int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi)
        {
            if (LogInformationEnabled) _logger.Information("{Method} start", nameof(GetMessageArchivePage));
            Stopwatch sw = null;
            if(IsTrace)
                sw = Stopwatch.StartNew();
            try
            {
                if (LogVerboseEnabled) _logger.Verbose($"{{Method}} args: "
                    + $"take:{take}, "
                    + $"skip:{skip}, "
                    + $"textFilter:{textFilter}, "
                    + $"dateFrom:{dateFrom}, "
                    + $"dateTo:{dateTo}, "
                    + $"mmsi:{mmsi}, "
                    , nameof(GetMessageArchivePage));

                using(var db = new DbContext())
                {
                    return _policy.Execute(() => _impl.GetMessageArchivePage(db, take, skip, textFilter, dateFrom, dateTo, mmsi));
                }
            }
            catch(BrokenCircuitException bcex)
            {
                _logger.Warning($"{{Method}} {nameof(BrokenCircuitException)}, return empty", nameof(GetMessageArchivePage));
                return new List<string>();
            }
            catch(Exception ex)
            {
                if(IsTrace) sw.Stop();

               _logger.Error(ex, nameof(GetMessageArchivePage));
            }
            finally
            {
                if(IsTrace) 
                {
                    sw.Stop();
                    if (LogDebugEnabled) _logger.Debug("{Method} finish, {Duration} ms", nameof(GetMessageArchivePage), sw.ElapsedMilliseconds);
                }
            }

            return null;
        }
        /// <summary>Получение статистики сообщений</summary>
        public List<string> GetMessageStatPage (int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo)
        {
            if (LogInformationEnabled) _logger.Information("{Method} start", nameof(GetMessageStatPage));
            Stopwatch sw = null;
            if(IsTrace)
                sw = Stopwatch.StartNew();
            try
            {
                if (LogVerboseEnabled) _logger.Verbose($"{{Method}} args: "
                    + $"take:{take}, "
                    + $"skip:{skip}, "
                    + $"textFilter:{textFilter}, "
                    + $"dateFrom:{dateFrom}, "
                    + $"dateTo:{dateTo}, "
                    , nameof(GetMessageStatPage));

                using(var db = new DbContext())
                {
                    return _policy.Execute(() => _impl.GetMessageStatPage(db, take, skip, textFilter, dateFrom, dateTo));
                }
            }
            catch(BrokenCircuitException bcex)
            {
                _logger.Warning($"{{Method}} {nameof(BrokenCircuitException)}, return empty", nameof(GetMessageStatPage));
                return new List<string>();
            }
            catch(Exception ex)
            {
                if(IsTrace) sw.Stop();

               _logger.Error(ex, nameof(GetMessageStatPage));
            }
            finally
            {
                if(IsTrace) 
                {
                    sw.Stop();
                    if (LogDebugEnabled) _logger.Debug("{Method} finish, {Duration} ms", nameof(GetMessageStatPage), sw.ElapsedMilliseconds);
                }
            }

            return null;
        }
    } 
}