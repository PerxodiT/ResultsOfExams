namespace StudSigns.Migrations.StudentMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentNumber = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 8),
                        DateOfBirth = c.DateTime(nullable: false),
                        Group = c.String(nullable: false),
                        Specialty = c.String(nullable: false),
                        Faculty = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentNumber);
            
            CreateTable(
                "dbo.SessionResults",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExamDate = c.DateTime(nullable: false),
                        ExamMark = c.Short(nullable: false),
                        Discipline_ID = c.Int(nullable: false),
                        Student_StudentNumber = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Disciplines", t => t.Discipline_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentNumber, cascadeDelete: true)
                .Index(t => t.Discipline_ID)
                .Index(t => t.Student_StudentNumber);
            
            CreateTable(
                "dbo.Disciplines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Teacher = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SessionResults", "Student_StudentNumber", "dbo.Students");
            DropForeignKey("dbo.SessionResults", "Discipline_ID", "dbo.Disciplines");
            DropIndex("dbo.SessionResults", new[] { "Student_StudentNumber" });
            DropIndex("dbo.SessionResults", new[] { "Discipline_ID" });
            DropTable("dbo.Disciplines");
            DropTable("dbo.SessionResults");
            DropTable("dbo.Students");
        }
    }
}
