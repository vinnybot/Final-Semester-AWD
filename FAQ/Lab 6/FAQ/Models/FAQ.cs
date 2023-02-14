﻿namespace FAQ.Models
{
    public class FAQ
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;

        public string TopicId = string.Empty;

        public Topic Topic { get; set; } = null!;

        public string CategoryId { get; set; } = string.Empty;

        public Category Category { get; set; } = null!;

    }
}
