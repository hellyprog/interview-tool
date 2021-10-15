using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class Technology
    {
        public int TechnologyId { get; set; }
        public string Name { get; set; }
        public List<Topic> Topics { get; set; }

        private Technology() { }

        public Technology(string name)
        {
            Name = name;
        }
    }
}
