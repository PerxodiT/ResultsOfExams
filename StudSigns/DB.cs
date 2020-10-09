using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudSigns
{
    class SessionResult
    {
        public int ID { get; set; }
        [ForeignKey("Discipline")]
        public int DisciplineID { get; set; }



        [Required]
        public DateTime ExamDate { get; set; }
        [Required]
        public short ExamMark { get; set; }

        public Discipline Discipline { get; set; }
        public Student Student { get; set; }
    }

    class SessionContext : DbContext
    {
        public SessionContext() : base("DbConnect")
        { }
        public DbSet<SessionResult> Sessions { get; set; }
    }
    class Student
    {
        [Required]
        [Key]
        public string StudentNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(8)]
        public string Gender { get; set; }
        public List<SessionResult> sessionResults { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Group { get; set; }
        [Required]
        public string Specialty { get; set; }
        [Required]
        public string Faculty { get; set; }
        public Student()
        {
            sessionResults = new List<SessionResult>();
        }
    }

    class StudentContext : DbContext
    {
        public StudentContext() :
            base("DbConnect")
        {
        }
        public DbSet<Student> Students { get; set; }
    }

    class Discipline
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public List<SessionResult> sessionResults { get; set; }

        public Discipline()
        {
            sessionResults = new List<SessionResult>();
        }
    }

    class DisciplineContext : DbContext
    {
        public DisciplineContext() : base("DbConnect")
        { }
        public DbSet<Discipline> Disciplines { get; set; }
    }

    class Administrator
    {
        //public int ID { get; set; }
        [Required]
        [Key] 
        public string Login { get; set; }
        [Required]
        public string Pass { get; set; }
    }

    class AdministratorContext : DbContext
    {
        public AdministratorContext() : base("DbConnect")
            { }
        public DbSet<Administrator> Admins { get; set; }
    }

    
}
