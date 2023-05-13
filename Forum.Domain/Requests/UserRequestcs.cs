using Newtonsoft.Json;

namespace Forum.Domain.Requests;

public class UserRequest
{
    [JsonProperty("username")] public String Username { get; set; }
    [JsonProperty("image")] public String Image { get; set; }
}


