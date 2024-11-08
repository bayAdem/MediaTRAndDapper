namespace MediaTRAndDapper.Mapping.Profile;

using AutoMapper;
using MediaTRAndDapper.CQRS.Commands.Category.AddCategories;
using MediaTRAndDapper.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, AddCategoryRequest>();
    }
}
