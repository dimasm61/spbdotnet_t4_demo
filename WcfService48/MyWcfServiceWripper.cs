using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService48
{
    public partial class MyWcfServiceWripper: IMyWcfService
    {
        public bool IsTrace = true;

        private MyWcfServiceImpl _impl;

        public MyWcfServiceWripper(MyWcfServiceImpl impl)
        {
            _impl = impl;
        }

        private void Log(string methodName, object data)
        {

        }
    }
}
