using LoggingSQLDemo2022.Data;
using System;
using System.Linq;

namespace LoggingSQLDemo2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            var games = db.Games.ToList();
            foreach (var g in games)
            {
                Console.WriteLine(g);
            }
        }
    }
}
