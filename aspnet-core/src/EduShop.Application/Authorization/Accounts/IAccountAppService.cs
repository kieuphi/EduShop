using System.Threading.Tasks;
using Abp.Application.Services;
using EduShop.Authorization.Accounts.Dto;

namespace EduShop.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
