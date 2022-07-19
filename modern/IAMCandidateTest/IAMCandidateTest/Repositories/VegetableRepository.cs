using AutoMapper;
using IAMCandidateTest.Data;
using IAMCandidateTest.Models;
using IAMCandidateTest.Models.Enums;
using IAMCandidateTest.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace IAMCandidateTest.Repositories
{

    public interface IVegetableRepository
    {
        Task<VegetableViewModel> GetVegetableDetails(int VegetableId);
    }
    public class VegetableRepository : BaseRepository, IVegetableRepository
    {
        public VegetableRepository(IAMCandidateTestDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<VegetableViewModel> GetVegetableDetails(int vegetableId)
        {
            var Vegetable = await context.Vegetables.AsNoTracking().Where(a => a.Id == vegetableId).SingleAsync();

            var VegetableViewModel = mapper.Map<Vegetable, VegetableViewModel>(Vegetable);

            return VegetableViewModel;
        }

    }
}