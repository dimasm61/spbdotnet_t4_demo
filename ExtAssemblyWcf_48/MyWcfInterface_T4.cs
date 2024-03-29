﻿
using System;
using System.Collections.Generic;

namespace ExtAssemblyWcf_48
{
    public partial interface MyWcfInterface
    {
        /// <summary>Получения списка сообщений.</summary>
        List<string> GetMessagePage (int take, int skip, string textFilter, int? mmsi);
        /// <summary>Получения списка сообщений из архива</summary>
        List<string> GetMessageArchivePage (int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi);
    } 
}