using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class ChapterResult
    {
        public int ChapterResultId { get; set; }
        public string Name { get; set; }
        public double Point { get; set; }
        public double Weight { get; set; }
        public List<TopicResult> TopicResults { get; set; }
    }
}
