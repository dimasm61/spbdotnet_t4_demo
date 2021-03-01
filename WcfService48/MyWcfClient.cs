using System;

namespace WcfService48
{
    public partial class MyWcfClient: System.ServiceModel.ClientBase<IMyWcfService>, IMyWcfService
    {
    }
}
