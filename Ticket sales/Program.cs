using System.Xml;
using System.Xml.Linq;
using Ticket_sales.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        ApplicationContext ef = new ApplicationContext();

        Ticket tick = new Ticket()
        {
            Passanger = ef.Passangers.FirstOrDefault(x => x.Name == Console.ReadLine()),
            PointDeparture = ef.Points.FirstOrDefault(x => x.Value == Console.ReadLine()),
            PointArrival = ef.Points.FirstOrDefault(x => x.Value == Console.ReadLine()),
            DateArrive = DateTime.Now.AddHours(4)
            

        };

    ef.Add(tick);
        ef.SaveChanges();

//        Passenger p = new Passenger()
//        {
//            Name = "Положай Настя",
//            Phone = "89374368954"
//        };

//        Passanger p2 = new Passanger()
//        {
//            Name = "Николаева Алина",
//            Phone = "89178626487"
//        };

//        Passanger p3 = new Passanger()
//        {
//            Name = "Тимакова Лиза",
//            Phone = "89379993476"
//        };

//        if (!ef.Passangers.Any(x=> x.Name == p.Name)) 
//        {
//            ef.Add(p);
//        }

        
//        ef.Add(p2);
//        ef.Add(p3);
   }
}
