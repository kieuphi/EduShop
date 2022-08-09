using Abp.Application.Services;
using EduShop.MultiTenancy.Dto;

namespace EduShop.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

