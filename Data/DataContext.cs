using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bytesmarknad_webservice.Data
{
    public class DataContext : IdentityDbContext//<IdentityUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }
    }
}
