

using System;
using System.Collections.Generic; 
using System.ServiceModel;

namespace WcfService48
{
    public interface IMyWcfServiceImpl
    {
        /// <summary>Получение списка сообщений.</summary>
        List<string> GetMessagePage (DbContext db, int take, int skip, string textFilter, int? mmsi);

        /// <summary>Получение списка сообщений из архива</summary>
        List<string> GetMessageArchivePage (DbContext db, int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi);

        /// <summary>Получение списка сообщений из архива</summary>
        List<string> GetMessageArchivePage2 (DbContext db, int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi);

    } 
}