using System.Threading.Tasks;
using Abp.Application.Services;
using Backend.Authorization.Accounts.Dto;

namespace Backend.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
