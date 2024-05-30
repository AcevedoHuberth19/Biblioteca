namespace Biblioteca.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BibliotecaMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Biblioteca.Nacionalidad", "Activo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Biblioteca.Nacionalidad", "Activo");
        }
    }
}
