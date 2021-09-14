using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTool.Application.DTOs
{
    public class InterviewDTO
    {
        public int InterviewId { get; set; }
        public string CandidateName { get; set; }
        public List<ChapterResultDTO> ChapterResults { get; set; }
    }
}
