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
            new Adress {VoorNaam = "Theo", AchterNaam = "Boer", Straat = "Slinger", Plaats = "Alkmaar", InvoerDatum = DateTime.Now - TimeSpan.FromDays(10) },
            new Adress {VoorNaam = "Tineke", AchterNaam = "Lub", Straat = "Baan 23", Plaats = "Maastricht", InvoerDatum = DateTime.Now} };
    }

    public static Adress Single()
    {
      return new Adress { VoorNaam = "Theo", AchterNaam = "Boer", Straat = "Slinger", Plaats = "Alkmaar" };
    }

  }
}
