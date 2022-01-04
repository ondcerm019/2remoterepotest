using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSQLDemo2022.Models
{
    internal class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
