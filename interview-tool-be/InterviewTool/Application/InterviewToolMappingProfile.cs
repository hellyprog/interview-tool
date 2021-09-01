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
        }
    }
}
