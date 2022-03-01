using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst01.Entities
{
   public class Platafoma
    {
        public Guid Id { get; set; }
        public MeusJogos meusJogos { get; set; }
    }
}
