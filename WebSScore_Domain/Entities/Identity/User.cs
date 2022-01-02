using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public string AboutMyself { get; set; }
}