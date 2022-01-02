using Microsoft.AspNet.Identity.EntityFramework;

namespace WebStore.Domain.Entities.Identity;

public class Role : IdentityRole
{
    public string Description { get; set; }
}
