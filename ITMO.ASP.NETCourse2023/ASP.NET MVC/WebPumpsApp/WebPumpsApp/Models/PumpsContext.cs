using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using WebPumpsApp.Models;

namespace WebPumpsApp.Data
{
    public class PumpsContext : DbContext
    {
        public PumpsContext(DbContextOptions<PumpsContext> options)
        : base(options)
        { }
        public DbSet<Pump> Pumps { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}
