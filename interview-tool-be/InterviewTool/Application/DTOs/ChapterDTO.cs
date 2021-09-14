using System.Collections.Generic;

namespace InterviewTool.Application.DTOs
{
    public class ChapterDTO
    {
        public int ChapterId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public List<TopicDTO> Topics { get; set; }
    }
}
