using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class Interview
    {
        public int InterviewId { get; set; }
        public string CandidateName { get; set; }
        public bool IsFinished { get; set; }
        public List<ChapterResult> ChapterResults { get; set; }

        public Interview(string candidateName, bool isFinished = false)
        {
            CandidateName = candidateName;
            IsFinished = isFinished;
        }
    }
}
