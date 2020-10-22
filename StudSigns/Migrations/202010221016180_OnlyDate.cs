namespace StudSigns.Migrations.StudentMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnlyDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "DateOfBirth", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
