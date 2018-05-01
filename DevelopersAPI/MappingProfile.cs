using AutoMapper;

namespace Developers.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DataModel.Models.Developer, Model.Models.Developers.Developer>();
            CreateMap<DataModel.Models.Skill, Model.Models.Developers.Skill>();
        }
    }
}