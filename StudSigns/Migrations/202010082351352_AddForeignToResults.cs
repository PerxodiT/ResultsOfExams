namespace StudSigns.Migrations.StudentMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignToResults : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SessionResults", "Student_StudentNumber", "dbo.Students");
            DropIndex("dbo.SessionResults", new[] { "Student_StudentNumber" });
            RenameColumn(table: "dbo.SessionResults", name: "Discipline_ID", newName: "DisciplineID");
            RenameIndex(table: "dbo.SessionResults", name: "IX_Discipline_ID", newName: "IX_DisciplineID");
            AlterColumn("dbo.SessionResults", "Student_StudentNumber", c => c.String(maxLength: 128));
            CreateIndex("dbo.SessionResults", "Student_StudentNumber");
            AddForeignKey("dbo.SessionResults", "Student_StudentNumber", "dbo.Students", "StudentNumber");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SessionResults", "Student_StudentNumber", "dbo.Students");
            DropIndex("dbo.SessionResults", new[] { "Student_StudentNumber" });
            AlterColumn("dbo.SessionResults", "Student_StudentNumber", c => c.String(nullable: false, maxLength: 128));
            RenameIndex(table: "dbo.SessionResults", name: "IX_DisciplineID", newName: "IX_Discipline_ID");
            RenameColumn(table: "dbo.SessionResults", name: "DisciplineID", newName: "Discipline_ID");
            CreateIndex("dbo.SessionResults", "Student_StudentNumber");
            AddForeignKey("dbo.SessionResults", "Student_StudentNumber", "dbo.Students", "StudentNumber", cascadeDelete: true);
        }
    }
}
