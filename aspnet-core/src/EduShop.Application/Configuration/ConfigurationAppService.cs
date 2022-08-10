using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EduShop.Configuration.Dto;

namespace EduShop.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EduShopAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
