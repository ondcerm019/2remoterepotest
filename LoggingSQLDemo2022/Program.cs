using LoggingSQLDemo2022.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LoggingSQLDemo2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            /*var games = (from g in db.Games
                         join c in db.Companies on g.DeveloperId equals c.CompanyId
                         select new { Name = g.Name, Developer = c.Name }).ToList();*/
            var game = db.Games.Where(g => g.GameId == 1).SingleOrDefault();

            Console.WriteLine(game.Name);
            db.Entry(game).Collection(g => g.Tags).Query().Where(t => t.Text == "RPG").FirstOrDefault();
            foreach (var t in game.Tags)
            {
                Console.WriteLine(t.Text);
            }
        }
    }
}
