
using System;
using System.Collections.Generic; 

namespace WcfService48
{
    public interface ITestOfMyWcfService
    {
        /// <summary>Получение списка сообщений.</summary>
        void TestOf_GetMessagePage_Method();

        /// <summary>Получение списка сообщений из архива</summary>
        void TestOf_GetMessageArchivePage_Method();

    } 
}