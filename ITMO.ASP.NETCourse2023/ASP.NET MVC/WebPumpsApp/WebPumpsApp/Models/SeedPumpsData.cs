using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using WebPumpsApp.Data;
using static Humanizer.In;

namespace WebPumpsApp.Models
{
    public class SeedPumpsData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PumpsContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<PumpsContext>>()))
            {
                if (context == null || context.Pumps == null)
                {
                    throw new ArgumentNullException("Null CreditContext");
                }
              
                if (context.Pumps.Any())
                {
                    return;
                }
                context.Pumps.Add(new Pump 
                {   Head = "SRN 1.0",
                    Flow = 10,
                    Pressure = 20,
                    Power = 15,
                    IntDiam = 25,
                    OutdDiam = 20,
                    Weight = 45 
                 });

                context.Pumps.Add(new Pump
                {
                    Head = "SRN 2.0",
                    Flow = 30,
                    Pressure = 50,
                    Power = 20,
                    IntDiam = 30,
                    OutdDiam = 25,
                    Weight = 55
                });
                context.Pumps.Add(new Pump
                {
                    Head = "SRN 3.0",
                    Flow = 50,
                    Pressure = 50,
                    Power = 35,
                    IntDiam = 50,
                    OutdDiam = 60,
                    Weight = 80
                });
                context.Pumps.Add(new Pump
                {
                    Head = "SRN 4.0",
                    Flow = 70,
                    Pressure = 60,
                    Power = 30,
                    IntDiam = 80,
                    OutdDiam = 60,
                    Weight = 125
                });
                context.Pumps.Add(new Pump
                {
                    Head = "SRN 5.0",
                    Flow = 100,
                    Pressure = 80,
                    Power = 45,
                    IntDiam = 125,
                    OutdDiam = 100,
                    Weight = 345
                });


                context.SaveChanges();
            }
        }
    }
}
