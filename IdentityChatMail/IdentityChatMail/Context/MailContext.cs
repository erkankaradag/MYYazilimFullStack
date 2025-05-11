using IdentityChatMail.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatMail.Context
{
    public class MailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HURGENC\\SQLEXPRESS;Initial Catalog=EmailChatDb;Integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet<Message>Messages { get; set; }
    }
}
