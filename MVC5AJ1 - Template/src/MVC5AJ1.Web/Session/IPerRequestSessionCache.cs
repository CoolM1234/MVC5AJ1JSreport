using System.Threading.Tasks;
using MVC5AJ1.Sessions.Dto;

namespace MVC5AJ1.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
