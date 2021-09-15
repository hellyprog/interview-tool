using System.Collections.Generic;

namespace InterviewTool.Application.DTOs
{
    public class ChapterResultDTO
    {
        public int ChapterResultId { get; set; }
        public double Point { get; set; }
        public int ChapterId { get; set; }
        public int InterviewId { get; set; }
        public List<TopicResultDTO> TopicResults { get; set; }
    }
}
