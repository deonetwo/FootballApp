using FootballApp.Server.Models;

namespace FootballApp.Server.Services.Interfaces
{
    public interface IPositionsService
    {
        Task<IEnumerable<Position>> GetPositionsList();
    }
}
