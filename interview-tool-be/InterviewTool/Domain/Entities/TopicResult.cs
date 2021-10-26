namespace InterviewTool.Domain.Entities
{
    public class TopicResult
    {
        public int TopicResultId { get; private set; }
        public int Point { get; private set; }
        public int? TopicId { get; private set; }
        public int ChapterResultId { get; private set; }
        public Topic Topic { get; private set; }
        public ChapterResult ChapterResult { get; private set; }

        private TopicResult() { }

        public TopicResult(int chapterResultId, int point, int topicId)
        {
            ChapterResultId = chapterResultId;
            Point = point;
            TopicId = topicId;
        }

        public void UpdatePoint(int point)
        {
            Point = point;
        }
    }
}
