using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Meetings_App_Server.Models.Domains;
using System.Reflection.Emit;
using Meetings_App_Server.Models;
using Meetings_app_server.Models.Domain;
namespace Meetings_App_Server.Data;

public class ApplicationDbContext : IdentityDbContext


{

    public DbSet<Meeting> Meetings { get; set; }

    // public DbSet<Attendee> Attendee { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

    {

    }

    protected override void OnModelCreating(ModelBuilder builder)

    {

        base.OnModelCreating(builder);

        var readerRoleId = "a71a55d6-99d7-4123-b4e0-1218ecb90e3e";

        var writerRoleId = "c309fa92-2123-47be-b397-a1c77adb502c";

        var meetings = new List<Meeting>

            {

                new Meeting

                {

                    Id = 1,

                    Name = "Google marketing campaign",

                    Description = "Increasing brand awareness and spreading information about new products",

                    Date = new DateTime(2020, 10, 28),

                    StartTime = new TimeOnly(9, 0),

                    EndTime = new TimeOnly(10, 30)

                }

            };

        builder.Entity<Meeting>().HasData(meetings);

        var roles = new List<IdentityRole>

        {

            new IdentityRole

            {

                Id = readerRoleId,

                ConcurrencyStamp = readerRoleId,

                Name = "Reader",

                NormalizedName = "Reader".ToUpper()

            },

            new IdentityRole

            {

                Id = writerRoleId,

                ConcurrencyStamp = writerRoleId,

                Name = "Writer",

                NormalizedName = "Writer".ToUpper()

            }

        };

        builder.Entity<IdentityRole>().HasData(roles);

    }

}
