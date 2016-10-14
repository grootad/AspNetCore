using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreWebPage.Models
{
  public class Adress
  {
    public static List<Adress> List()
    {
       return new List<Adress>
            {
            new Adress {VoorNaam = "Denise", AchterNaam = "Groot", Straat = "Bisschopskroft 5", Plaats = "Egmond"},
            new Adress {VoorNaam = "Mariska", AchterNaam = "Groot", Straat = "Bisschopskroft 5", Plaats = "Egmond"} };
    }

    public string VoorNaam { get; set; }
    public string AchterNaam { get; set; }
    public string Straat { get; set; }
    public string Plaats { get; set; }
  }
}
