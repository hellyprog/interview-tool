﻿using System.Collections.Generic;

namespace InterviewTool.Entities
{
    public class Chapter
    {
        public int ChapterId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Point { get; set; }
        public List<Topic> Topics { get; set; }
    }
}
