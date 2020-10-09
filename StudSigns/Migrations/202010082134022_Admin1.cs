namespace StudSigns.Migrations.AdminMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 128),
                        Pass = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Login);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Administrators");
        }
    }
}
