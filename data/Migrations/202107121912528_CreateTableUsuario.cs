namespace data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableUsuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        SobreNome = c.String(),
                        Idade = c.Int(nullable: false),
                        Email = c.String(),
                        Cidade = c.String(),
                        Rua = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
