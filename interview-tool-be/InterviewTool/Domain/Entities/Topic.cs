using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class Topic
    {
        public int TopicId { get; private set; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int ChapterId { get; private set; }
        public int? TechnologyId { get; private set ; }
        public Chapter Chapter { get; private set; }
        public List<TopicResult> TopicResults { get; private set; }
        public Technology Technology { get; private set; }

        private Topic() { }

        public Topic(string name, double weight, int chapterId, int technologyId)
        {
            Name = name;
            Weight = weight;
            ChapterId = chapterId;
            TechnologyId = technologyId;
        }

        public void Update(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public void UpdateName(string name)
        {
            Name = name;
        }

        public void UpdateWeight(double weight)
        {
            Weight = weight;
        }
    }
}
