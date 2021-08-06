using System.Collections.Generic;

namespace InterviewTool.Entities
{
    public class Interview
    {
        public int InterviewId { get; set; }
        public string CandidateName { get; set; }
        public List<ChapterResult> ChapterResults { get; set; }
    }
}
