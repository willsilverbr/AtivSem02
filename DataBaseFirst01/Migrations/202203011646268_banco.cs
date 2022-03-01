namespace DataBaseFirst01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogador",
                c => new
                    {
                        ID_JOGADOR = c.Guid(nullable: false),
                        NOME = c.String(nullable: false, maxLength: 50),
                        EMAIL = c.String(nullable: false, maxLength: 50),
                        STATUS_JOGADOR = c.String(nullable: false, maxLength: 50),
                        plataforma = c.String(),
                        meusJogos_id = c.Guid(),
                    })
                .PrimaryKey(t => t.ID_JOGADOR)
                .ForeignKey("dbo.MeusJogos", t => t.meusJogos_id)
                .Index(t => t.meusJogos_id);
            
            CreateTable(
                "dbo.MeusJogos",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        JogoPlataforma = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogador", "meusJogos_id", "dbo.MeusJogos");
            DropIndex("dbo.Jogador", new[] { "meusJogos_id" });
            DropTable("dbo.MeusJogos");
            DropTable("dbo.Jogador");
        }
    }
}
