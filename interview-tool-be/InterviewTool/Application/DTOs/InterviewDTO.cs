using System.Collections.Generic;

namespace InterviewTool.Application.DTOs
{
    public class InterviewDTO
    {
        public int InterviewId { get; set; }
        public bool IsFinished { get; set; }
        public string CandidateName { get; set; }
        public List<ChapterResultDTO> ChapterResults { get; set; }
    }
}
