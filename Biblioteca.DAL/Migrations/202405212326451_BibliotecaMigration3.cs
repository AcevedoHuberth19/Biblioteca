namespace Biblioteca.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class BibliotecaMigration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Biblioteca.DetalleLibro",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    LibroId = c.Int(nullable: false),
                    AutorId = c.String(nullable: false),
                    Autor_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Biblioteca.Autor", t => t.Autor_Id)
                .ForeignKey("Biblioteca.Libro", t => t.LibroId, cascadeDelete: true)
                .Index(t => t.LibroId)
                .Index(t => t.Autor_Id);

            CreateTable(
                "Biblioteca.Libro",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Codigo = c.String(nullable: false),
                    Nombre = c.String(nullable: false),
                    FechaDePublicacion = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("Biblioteca.DetalleLibro", "LibroId", "Biblioteca.Libro");
            DropForeignKey("Biblioteca.DetalleLibro", "Autor_Id", "Biblioteca.Autor");
            DropIndex("Biblioteca.DetalleLibro", new[] { "Autor_Id" });
            DropIndex("Biblioteca.DetalleLibro", new[] { "LibroId" });
            DropTable("Biblioteca.Libro");
            DropTable("Biblioteca.DetalleLibro");
        }
    }
}
