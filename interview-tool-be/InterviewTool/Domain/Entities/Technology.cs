using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class Technology
    {
        public int TechnologyId { get; private set; }
        public string Name { get; private set; }
        public List<Topic> Topics { get; private set; }

        private Technology() { }

        public Technology(string name)
        {
            Name = name;
        }

        public void UpdateName(string name)
        {
            Name = name;
        }
    }
}
