using AutoMapper;
using IAMCandidateTest.Data;
using IAMCandidateTest.Models;
using IAMCandidateTest.Models.Enums;
using IAMCandidateTest.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace IAMCandidateTest.Repositories
{

    public interface IAnimalRepository
    {
        Task<AnimalViewModel> GetAnimalDetails(int animalId);
    }
    public class AnimalRepository : BaseRepository, IAnimalRepository
    {
        public AnimalRepository(IAMCandidateTestDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<AnimalViewModel> GetAnimalDetails(int animalId)
        {
            var animal = await context.Animals.AsNoTracking().Where(a => a.Id == animalId)
                .Include(a => a.TaxClass)
                .Include(a => a.TaxFamily)
                .Include(a => a.TaxGenus)
                .Include(a => a.TaxOrder)
                .Include(a => a.TaxPhylum)
                .Include(a => a.TaxSpecies)
                .SingleAsync();

            var animalViewModel = mapper.Map<Animal, AnimalViewModel>(animal);

            return animalViewModel;
        }

    }
}