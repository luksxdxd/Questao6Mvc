namespace MvcProva6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alunoNovo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlunoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Endereco = c.String(),
                        Filiacao = c.String(nullable: false),
                        Curso = c.String(nullable: false),
                        Telefone = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AlunoModels");
        }
    }
}
