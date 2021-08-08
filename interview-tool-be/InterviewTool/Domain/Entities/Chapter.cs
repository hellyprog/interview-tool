using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class Chapter
    {
        public int ChapterId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public List<Topic> Topics { get; set; }
    }
}
