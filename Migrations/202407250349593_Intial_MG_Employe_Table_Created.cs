namespace Employee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial_MG_Employe_Table_Created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employes");
        }
    }
}
