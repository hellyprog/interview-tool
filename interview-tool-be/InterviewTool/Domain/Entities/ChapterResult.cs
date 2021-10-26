using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class ChapterResult
    {
        public int ChapterResultId { get; private set; }
        public double Point { get; private set; }
        public int? ChapterId { get; private set; }
        public int InterviewId { get; private set; }
        public Chapter Chapter { get; private set; }
        public Interview Interview { get; private set; }
        public List<TopicResult> TopicResults { get; private set; }

        private ChapterResult() { }

        public ChapterResult(int interviewId, double point, int chapterId)
        {
            InterviewId = interviewId;
            Point = point;
            ChapterId = chapterId;
        }

        //recalculate on topic result update?
        public void UpdatePoint(double point)
        {
            Point = point;
        }
    }
}
