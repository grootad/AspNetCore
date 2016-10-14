using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreWebPageNet.Models
{
  public class Adress:My45.Adress
  {
    public static List<Adress> List()
    {
      return new List<Adress>
            {
            new Adress {VoorNaam = "Tamara", AchterNaam = "Groot", Straat = "Bisschopskroft 5", Plaats = "Egmond", InvoerDatum = DateTime.Now - TimeSpan.FromDays(10) },
            new Adress {VoorNaam = "Mariska", AchterNaam = "Groot", Straat = "Bisschopskroft 5", Plaats = "Egmond", InvoerDatum = DateTime.Now} };
    }

    public static Adress Single()
    {
      return new Adress { VoorNaam = "Tamara", AchterNaam = "Groot", Straat = "Bisschopskroft 5", Plaats = "Egmond" };
    }

  }
}
