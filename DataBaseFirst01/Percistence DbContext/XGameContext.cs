using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseFirst01.Entities;
using DataBaseFirst01.Percistence_DbContext.Map;

namespace DataBaseFirst01.Percistence
{
    public class XGameContext : DbContext
    {
        public XGameContext() : base("Server=LAPTOP-DNO3086A\\SQLEXPRESS; DataBase=xgame; Integrated Security=True;")
        //Realizando a string de Conexao para o CodFirst
        {
            /*
            Configuration.ProxyCreationEnabled = false;
            //Desabilitando o Proxy

            Configuration.LazyLoadingEnabled = false;
            //Tira a apresentação de objetos complexos, apresenta menos dados desnecessarios
            //e garante a perfomance. */

        }

        public IDbSet<Jogador> Jogadores { get; set; } //Nome usado para acessar os dados da sua tabela
        //public IDbSet<Jogo> Jogos { get; set; }

        //public IDbSet<PlataformaGamer> PlataformaGamers { get; set; }

        //public IDbSet<MeusJogos> MeusJogos { get; set; }
        //public IDbSet<PlataformaGamer> PlataformaGamerss { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
            //Seta a classe e faz a inicialização do banco por isso se aponta para o nome da mesma

            Database.SetInitializer<XGameContext>(null);

            //Mapeamento das janelas (o que precisa ser alimentado nas tebelas
            modelBuilder.Configurations.Add(new MapJogador());
            



            /* //Seta o Schema default
             //Modelbiulder.HasdefaltSchema("Apoio")

             //Remove a pluralização dos nomes das tabelas
             modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

             //Remove Exclusão em cascata
             modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
             modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

             //Setar para usar varchar ou inves de nvarchar
             modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));


             //Caso esqueça de informar o tamanho do compo ele irá colocar varchar de 100
             modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

             //Mapeia as entidades
             //ModelBuilde.Configurations.Add(new VeiculaMap()); 

             //#region Adiciona entidade mapeadas - automaticamente via Assembly 
             modelBuilder.Conventions.AddFromAssembly(typeof(XGameContext).Assembly);

            */
            base.OnModelCreating(modelBuilder);
             
        }


    }
}