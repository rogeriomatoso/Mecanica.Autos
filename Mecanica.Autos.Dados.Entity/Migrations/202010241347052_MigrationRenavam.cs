namespace Mecanica.Autos.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationRenavam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarroPasseio", "Renavam - UF", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarroPasseio", "Renavam - UF");
        }
    }
}
