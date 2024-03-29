﻿


using System;
using System.Collections.Generic;

namespace WcfService48
{
    public partial class MyWcfClient:IMyWcfService
    {
        /// <summary>Получение списка сообщений.</summary>
        public List<string> GetMessagePage (int take, int skip, string textFilter, int? mmsi)
        {
            return _policy.Execute(() => base.Channel.GetMessagePage(take, skip, textFilter, mmsi));
        }
        /// <summary>Получение списка сообщений из архива</summary>
        public List<string> GetMessageArchivePage (int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi)
        {
            return _policy.Execute(() => base.Channel.GetMessageArchivePage(take, skip, textFilter, dateFrom, dateTo, mmsi));
        }
        /// <summary>Получение списка сообщений из архива</summary>
        public List<string> GetMessageArchivePage2 (int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi)
        {
            return _policy.Execute(() => base.Channel.GetMessageArchivePage2(take, skip, textFilter, dateFrom, dateTo, mmsi));
        }
    } 
}