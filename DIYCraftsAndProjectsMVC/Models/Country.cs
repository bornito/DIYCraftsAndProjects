using System;
using System.Collections.Generic;

namespace DIYCraftsAndProjectsMVC.Models;

/*
 * L kao Liskov Substitution Principle (LSP)
 * HomeLand je podtip od Country, možemo koristiti instancu od HomeLand
 * kada god koristimo Country, metoda Greet se ponaša isto u oba slučaja
 * Sve podklase se mogu zamjeniti s baznom klasom bez uzrokovanja problema
 *
 */

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual void Greet(string hello)
    {
        Console.WriteLine(hello);
    }
}

public partial class HomeLand : Country
{
    public override void Greet(string hello)
    {
        base.Greet(hello);
    }
}
