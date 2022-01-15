
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Polly.CircuitBreaker;

namespace ExtAssemblyWcf_48
{
    public partial class MyWcfClient
    {
        /// <summary>Получение списка сообщений.</summary> 
        public List<string> GetMessagePage(int take, int skip, string textFilter, int? mmsi)
        {
            return _policy.Execute(() => base.Channel.GetMessagePage(take, skip, textFilter, mmsi));
        }
        /// <summary>Получение списка сообщений из архива</summary> 
        public List<string> GetMessageArchivePage(int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi)
        {
            return _policy.Execute(() => base.Channel.GetMessageArchivePage(take, skip, textFilter, dateFrom, dateTo, mmsi));
        }
    } 
}