using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTool.Application.DTOs
{
    public class TopicResultDTO
    {
        public int TopicResultId { get; set; }
        public int? Point { get; set; }
        public int TopicId { get; set; }
        public int ChapterResultId { get; set; }
    }
}
