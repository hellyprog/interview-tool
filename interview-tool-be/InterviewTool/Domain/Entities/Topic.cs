namespace InterviewTool.Domain.Entities
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }

        private Topic() { }

        public Topic(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public void Update(Topic updated)
        {
            Name = updated.Name;
            Weight = updated.Weight;
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
