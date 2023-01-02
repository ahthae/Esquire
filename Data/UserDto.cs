namespace esquire.Data;

public class UserDto : IDto
{
    public string? Username { get; set; }
    public string? UserGuid { get; set; }
    public decimal? UserId { get; set; }
}