using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseFirst01.Entities;

namespace DataBaseFirst01.Percistence_DbContext.Map
{
    class MapJogador : EntityTypeConfiguration<Jogador>
    {
        public MapJogador() //NÃO ESQUECER: Esse Construtor deve ser public, senão o Migrations
                            //apresentará "Excepion relationship between" .
        {
            //Contrutor para mapear a tabela Jogador.
            //Se Não for definido aqui o Construtos cria os campos no seu padrao de sistema

            ToTable("Jogador");  //Definir o nome da tabela
            this.HasKey(p => p.id);//Chave Primaria
            this.Property(p => p.id).HasColumnName("ID_JOGADOR");
            this.Property(p => p.email).HasMaxLength(50).IsRequired().HasColumnName("EMAIL");
            this.Property(p => p.nome).HasMaxLength(50).IsRequired().HasColumnName("NOME");
            this.Property(p => p.status).HasMaxLength(50).IsRequired().HasColumnName("STATUS_JOGADOR");
            

        }
    }
}
