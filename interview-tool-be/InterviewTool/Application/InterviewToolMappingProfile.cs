using AutoMapper;
using InterviewTool.Application.DTOs;
using InterviewTool.Domain.Entities;

namespace InterviewTool.Application
{
    public class InterviewToolMappingProfile : Profile
    {
        public InterviewToolMappingProfile()
        {
            CreateMap<Chapter, ChapterDTO>();
            CreateMap<Topic, TopicDTO>()
                .ForMember(x => x.TechnologyName, x => x.MapFrom(y => y.Technology.Name));
            CreateMap<TopicResult, TopicResultDTO>()
                .ForMember(x => x.TechnologyId, x => x.Ignore())
                .ForMember(x => x.TechnologyName, x => x.Ignore());
            CreateMap<ChapterResult, ChapterResultDTO>();
            CreateMap<Interview, InterviewDTO>();
        }
    }
}
