using FootballApp.Server.Data;
using FootballApp.Server.Models;
using FootballApp.Server.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FootballApp.Server.Services
{
    public class PositionsService : IPositionsService
    {
        private readonly FootballDbContext _context;

        public PositionsService(FootballDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Position>> GetPositionsList()
        {
            return await _context.Positions
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync();
        }
    }
}
