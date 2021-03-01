

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WcfService48
{
    public partial class MyWcfServiceWripper
    {
        /// <summary>Получения списка сообщений.</summary>
        public List<string> GetMessagePage (int take, int skip, string textFilter, int? mmsi)
        {
            Stopwatch sw = null;
            if(IsTrace)
                sw = Stopwatch.StartNew();
            try
            {
                using(var db = new DbContext())
                {
                    return _impl.GetMessagePage(db, take, skip, textFilter, mmsi);
                }
            }
            catch(Exception ex)
            {
                if(IsTrace) sw.Stop();

                Log(nameof(GetMessagePage), ex);
            }
            finally
            {
                if(IsTrace) 
                {
                    sw.Stop();
                    Log(nameof(GetMessagePage), $"Elapsed {sw.ElapsedMilliseconds}ms");
                }
            }

            return null;
        }
        /// <summary>Получения списка сообщений из архива</summary>
        public List<string> GetMessageArchivePage (int take, int skip, string textFilter, DateTime? dateFrom, DateTime? dateTo, int? mmsi)
        {
            Stopwatch sw = null;
            if(IsTrace)
                sw = Stopwatch.StartNew();
            try
            {
                using(var db = new DbContext())
                {
                    return _impl.GetMessageArchivePage(db, take, skip, textFilter, dateFrom, dateTo, mmsi);
                }
            }
            catch(Exception ex)
            {
                if(IsTrace) sw.Stop();

                Log(nameof(GetMessageArchivePage), ex);
            }
            finally
            {
                if(IsTrace) 
                {
                    sw.Stop();
                    Log(nameof(GetMessageArchivePage), $"Elapsed {sw.ElapsedMilliseconds}ms");
                }
            }

            return null;
        }
    } 
}