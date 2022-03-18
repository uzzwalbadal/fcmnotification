using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Backend.Configuration.Dto;

namespace Backend.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BackendAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
