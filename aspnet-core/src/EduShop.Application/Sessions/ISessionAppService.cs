using System.Threading.Tasks;
using Abp.Application.Services;
using EduShop.Sessions.Dto;

namespace EduShop.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
