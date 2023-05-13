namespace Forum.Domain.Responses;

public class UserResponse
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Image { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}