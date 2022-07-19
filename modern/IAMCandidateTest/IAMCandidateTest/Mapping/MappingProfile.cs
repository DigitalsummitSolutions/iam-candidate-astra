using AutoMapper;
using IAMCandidateTest.Models;
using IAMCandidateTest.Models.ViewModels;

namespace IAMCandidateTest.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CategoryType, CategoryTypeViewModel>();

			CreateMap<Animal, AnimalViewModel>()
				.ForMember(a => a.CanFly, i => i.MapFrom(a => a.CanFly.HasValue && a.CanFly.Value == true ? "Yes" : "No"))
				.ForMember(a => a.TaxPhylum, i => i.MapFrom(a => a.TaxPhylum.Name) )
				.ForMember(a => a.TaxGenus, i => i.MapFrom(a => a.TaxGenus.Name))
				.ForMember(a => a.TaxFamily, i => i.MapFrom(a => a.TaxFamily.Name))
				.ForMember(a => a.TaxClass, i => i.MapFrom(a => a.TaxClass.Name))
				.ForMember(a => a.TaxOrder, i => i.MapFrom(a => a.TaxOrder.Name))
				.ForMember(a => a.TaxSpecies, i => i.MapFrom(a => a.TaxSpecies.Name))
				;
				

			CreateMap<Mineral, MineralViewModel>();

			CreateMap<Vegetable, VegetableViewModel>()
				.ForMember(a => a.IsBotanicalFruit, i => i.MapFrom(a => a.IsBotanicalFruit.HasValue && a.IsBotanicalFruit.Value == true ? "Yes" : "No"));
		}
	}
}