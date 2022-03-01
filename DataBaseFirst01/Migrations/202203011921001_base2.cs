namespace DataBaseFirst01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class base2 : DbMigration
    {//Usando o add-migration
        public override void Up()
        {
            DropForeignKey("dbo.Jogador", "meusJogos_id", "dbo.MeusJogos");
            DropIndex("dbo.Jogador", new[] { "meusJogos_id" });
            DropColumn("dbo.Jogador", "plataforma");
            DropColumn("dbo.Jogador", "meusJogos_id");
            DropTable("dbo.MeusJogos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MeusJogos",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        JogoPlataforma = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Jogador", "meusJogos_id", c => c.Guid());
            AddColumn("dbo.Jogador", "plataforma", c => c.String());
            CreateIndex("dbo.Jogador", "meusJogos_id");
            AddForeignKey("dbo.Jogador", "meusJogos_id", "dbo.MeusJogos", "id");
        }
    }
}
