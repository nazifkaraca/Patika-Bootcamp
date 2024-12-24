using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;

namespace Week14_2_Pratik.Data
{
    public class PratikContext : IdentityDbContext<IdentityUser>
    {
        public PratikContext(DbContextOptions<PratikContext> options) : base(options) { }
    }
}
