namespace InterviewTool.Domain.Entities
{
    public class TopicResult
    {
        public int TopicResultId { get; set; }
        public double Point { get; set; }
        public int? TopicId { get; set; }
        public int ChapterResultId { get; set; }
        public Topic Topic { get; set; }
        public ChapterResult ChapterResult { get; set; }

        private TopicResult() { }

        public TopicResult(int chapterResultId, int point, int topicId)
        {
            ChapterResultId = chapterResultId;
            Point = point;
            TopicId = topicId;
        }

        public void UpdatePoint(double point)
        {
            Point = point;
        }
    }
}
