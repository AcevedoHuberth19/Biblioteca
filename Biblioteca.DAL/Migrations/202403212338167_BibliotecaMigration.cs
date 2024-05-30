namespace Biblioteca.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BibliotecaMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Biblioteca.Autor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false),
                        Apellidos = c.String(nullable: false),
                        FechaDeNacimiento = c.DateTime(nullable: false),
                        NacionalidadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Biblioteca.Nacionalidad", t => t.NacionalidadId, cascadeDelete: true)
                .Index(t => t.NacionalidadId);
            
            CreateTable(
                "Biblioteca.Nacionalidad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Abreviatura = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Biblioteca.Autor", "NacionalidadId", "Biblioteca.Nacionalidad");
            DropIndex("Biblioteca.Autor", new[] { "NacionalidadId" });
            DropTable("Biblioteca.Nacionalidad");
            DropTable("Biblioteca.Autor");
        }
    }
}
