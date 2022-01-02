using Microsoft.AspNet.Identity.EntityFramework;
namespace WebStore.Domain.Entities.Identity;

public class User : IdentityUser
{
    public string AboutMyself { get; set; }
}