using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class ChapterResult
    {
        public int ChapterResultId { get; set; }
        public double Point { get; set; }
        public int? ChapterId { get; set; }
        public int InterviewId { get; set; }
        public Chapter Chapter { get; set; }
        public Interview Interview { get; set; }
        public List<TopicResult> TopicResults { get; set; }

        private ChapterResult() { }

        public ChapterResult(int interviewId, double point, int chapterId)
        {
            InterviewId = interviewId;
            Point = point;
            ChapterId = chapterId;
        }

        public void UpdatePoint(int point)
        {
            Point = point;
        }
    }
}
