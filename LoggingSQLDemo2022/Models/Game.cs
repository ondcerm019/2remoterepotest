using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSQLDemo2022.Models
{
    internal class Game
    {
        public int GameId { get; set; }

        public string Name { get; set; }
        public DateTime Realeased { get; set; }
        public Company Developer { get; set; }
        public int DeveloperId { get; set; }
        public ICollection<Tag> Tags { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
