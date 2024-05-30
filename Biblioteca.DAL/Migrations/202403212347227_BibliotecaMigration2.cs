namespace Biblioteca.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BibliotecaMigration2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("Biblioteca.Nacionalidad", "Activo");
        }
        
        public override void Down()
        {
            AddColumn("Biblioteca.Nacionalidad", "Activo", c => c.Boolean(nullable: false));
        }
    }
}
