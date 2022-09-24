

using System;
using System.Collections.Generic; 
using System.ServiceModel;

namespace WcfService48
{
    [ServiceContract]
    public interface IMyWcfServiceImpl
    {
        /// <summary>Получение списка сообщений.</summary>
        [OperationContract]
        List<string> GetMessagePage (DbContext db, int take, int skip, string textFilter, int? mmsi);

        /// <summary>Получение списка сообщений из архива</summary>
        [OperationContract]
        List<string> GetMessageArchivePage (DbContext db, int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi);

        /// <summary>Получение статистики сообщений</summary>
        [OperationContract]
        List<string> GetMessageStatPage (DbContext db, int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo);

    } 
}