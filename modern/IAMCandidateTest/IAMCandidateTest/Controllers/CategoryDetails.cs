using IAMCandidateTest.Models.Enums;
using IAMCandidateTest.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IAMCandidateTest.Controllers
{
    public class CategoryDetails : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IAnimalRepository animalRepository;
        private readonly IMineralRepository mineralRepository;
        private readonly IVegetableRepository vegetableRepository;
        public CategoryDetails(ICategoryRepository categoryRepository, IAnimalRepository animalRepository, IMineralRepository mineralRepository, IVegetableRepository vegetableRepository)
        {
            this.categoryRepository = categoryRepository;
            this.animalRepository = animalRepository;
            this.vegetableRepository = vegetableRepository;
            this.mineralRepository = mineralRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetCategoryByCategoryType(int categoryType)
        {
            try
            {
                var categories = await categoryRepository.GetCategories((CategoryTypeEnum)categoryType);
                return Json(categories.ToList());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }


        public virtual async Task<ActionResult> LoadDetailsViewDynamically(int categoryTypeId, int categoryId)
        {
            switch((CategoryTypeEnum)categoryTypeId)
            {
                case CategoryTypeEnum.Animal:
                    var animalData = await animalRepository.GetAnimalDetails(categoryId);
                    return PartialView("_DetailsPartial", animalData);
                case CategoryTypeEnum.Mineral:
                    var mineralData = await mineralRepository.GetMineralDetails(categoryId);
                    return PartialView("_DetailsPartial", mineralData);
                case CategoryTypeEnum.Vegetable:
                    var vegetableData = await vegetableRepository.GetVegetableDetails(categoryId);
                    return PartialView("_DetailsPartial", vegetableData);
            }

            return NotFound();
            
        }



    }
}
