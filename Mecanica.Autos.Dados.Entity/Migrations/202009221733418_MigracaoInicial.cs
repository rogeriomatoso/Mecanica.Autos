namespace Mecanica.Autos.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarroPasseio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(nullable: false, maxLength: 100),
                        Marca = c.String(nullable: false, maxLength: 100),
                        Cor = c.String(maxLength: 50),
                        Combustivel = c.String(nullable: false, maxLength: 10),
                        Ano = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarroPasseio");
        }
    }
}
