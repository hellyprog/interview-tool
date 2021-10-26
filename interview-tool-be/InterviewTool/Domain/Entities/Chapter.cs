using System.Collections.Generic;

namespace InterviewTool.Domain.Entities
{
    public class Chapter
    {
        public int ChapterId { get; private set; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public List<Topic> Topics { get; private set; }
        public List<ChapterResult> ChapterResults { get; private set; }

        private Chapter() { }

        public Chapter(string name, double weight)
        {
            Name = name;
            Weight = weight;
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
