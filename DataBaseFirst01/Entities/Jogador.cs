using System;

namespace DataBaseFirst01.Entities
{
    public class Jogador
    {

        public Guid id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public Platafoma plataforma { get; set; }
        public MeusJogos meusJogos { get; set; }
    }
}
