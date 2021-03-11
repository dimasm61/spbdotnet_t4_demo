using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtAssemblyWcf_48
{
    public class MyWcfServiceImpl
    {
        /// <summary>Получения списка сообщений.</summary>
        public List<string> GetMessagePage(DbContext db, int take, int skip, string textFilter, int? mmsi)
        {
            throw new NotImplementedException();
        }
        /// <summary>Получения списка сообщений из архива</summary>
        public List<string> GetMessageArchivePage(DbContext db, int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi)
        {
            throw new NotImplementedException();
        }
    }

    public class DbContext : IDisposable
    {
        public void Dispose()
        {
        }
    }
}
