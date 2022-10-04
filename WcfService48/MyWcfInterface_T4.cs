

using System;
using System.Collections.Generic; 
using System.ServiceModel;

namespace WcfService48
{
    [ServiceContract]
    public interface IMyWcfService
    {
        /// <summary>Получение списка сообщений.</summary>
        [OperationContract]
        List<string> GetMessagePage (int take, int skip, string textFilter, int? mmsi);

        /// <summary>Получение списка сообщений из архива</summary>
        [OperationContract]
        List<string> GetMessageArchivePage (int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi);

        /// <summary>Получение списка сообщений из архива</summary>
        [OperationContract]
        List<string> GetMessageArchivePage2 (int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi);

    } 
}