using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class Interview
    {
        public int InterviewId { get; private set; }
        public string CandidateName { get; private set; }
        public bool IsFinished { get; private set; }
        public List<ChapterResult> ChapterResults { get; private set; }

        public Interview(string candidateName, bool isFinished = false)
        {
            CandidateName = candidateName;
            IsFinished = isFinished;
        }

        public void UpdateCandidateName(string candidateName)
        {
            CandidateName = candidateName;
        }

        public void SetInterviewFinished()
        {
            IsFinished = true;
        }

    }
}
