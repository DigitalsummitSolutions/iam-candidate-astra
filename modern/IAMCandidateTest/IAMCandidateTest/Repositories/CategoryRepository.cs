using AutoMapper;
using IAMCandidateTest.Data;
using IAMCandidateTest.Models;
using IAMCandidateTest.Models.Enums;
using IAMCandidateTest.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace IAMCandidateTest.Repositories
{

    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryViewModel>> GetCategories(CategoryTypeEnum categoryType);
    }
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(IAMCandidateTestDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<CategoryViewModel>> GetCategories(CategoryTypeEnum categoryType)
        {
            switch (categoryType)
            {
                case CategoryTypeEnum.Animal:
                    return await context.Animals.AsNoTracking().OrderBy(a => a.Name).Select(a => new CategoryViewModel { Id = a.Id, Name = a.Name }).ToListAsync();
                case CategoryTypeEnum.Mineral:
                    return await context.Minerals.AsNoTracking().OrderBy(a => a.Name).Select(a => new CategoryViewModel { Id = a.Id, Name = a.Name }).ToListAsync();
                case CategoryTypeEnum.Vegetable:
                    return await context.Vegetables.AsNoTracking().OrderBy(a => a.Name).Select(a => new CategoryViewModel { Id = a.Id, Name = a.Name }).ToListAsync();
                default:
                    return new List<CategoryViewModel>();

            }

        }

    }
}