using System.Collections.Generic;
using Abp.Dependency;
using Abp.RealTime;

namespace MVC5AJ1.Authorization.Users
{
    public interface IUserLogoutInformer
    {
        void InformClients(IReadOnlyList<IOnlineClient> clients);
    }
}
