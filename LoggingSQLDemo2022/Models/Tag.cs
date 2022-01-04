using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSQLDemo2022.Models
{
    internal class Tag
    {
        public int TagId { get; set; }
        public string Text { get; set; }
        public Game Game { get; set; }
        public int GameId { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
