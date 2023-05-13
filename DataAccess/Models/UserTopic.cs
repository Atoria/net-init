using System;

namespace DataAccess.Models
{
    public class UserTopic
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
    }
}
