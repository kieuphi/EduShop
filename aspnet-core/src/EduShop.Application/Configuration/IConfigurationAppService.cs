using System.Threading.Tasks;
using EduShop.Configuration.Dto;

namespace EduShop.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
