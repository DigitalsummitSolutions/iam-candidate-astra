using AutoMapper;
using IAMCandidateTest.Data;
using IAMCandidateTest.Models;
using IAMCandidateTest.Models.Enums;
using IAMCandidateTest.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace IAMCandidateTest.Repositories
{

    public interface IMineralRepository
    {
        Task<MineralViewModel> GetMineralDetails(int mineralId);
    }
    public class MineralRepository : BaseRepository, IMineralRepository
    {
        public MineralRepository(IAMCandidateTestDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<MineralViewModel> GetMineralDetails(int mineralId)
        {
            var mineral = await context.Minerals.AsNoTracking().Where(a => a.Id == mineralId).SingleAsync();

            var mineralViewModel = mapper.Map<Mineral, MineralViewModel>(mineral);

            return mineralViewModel;
        }

    }
}