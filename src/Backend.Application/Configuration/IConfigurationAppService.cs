using System.Threading.Tasks;
using Backend.Configuration.Dto;

namespace Backend.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
