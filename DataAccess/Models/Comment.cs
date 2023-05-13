using System;

namespace DataAccess.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string UserComment { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
