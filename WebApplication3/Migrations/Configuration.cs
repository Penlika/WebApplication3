namespace WebApplication3.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication3.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication3.Models.SchoolContext context)
        {
            base.Seed(context);
            var lstStudents=new List<Student>();
            lstStudents.Add(new Student() { StudentName="sdadada"});
            lstStudents.Add(new Student() { StudentName = "sdawdsaad" });
            lstStudents.Add(new Student() { StudentName = "adwdazda" });
            lstStudents.Add(new Student() { StudentName = "sdawda" });
            lstStudents.ForEach(s=> context.Students.Add(s));
            var lstScore=new List<Grade>();
            lstScore.Add(new Grade() { GradeName = "DADWDA", Score = 9, StudentID = 1 });
            lstScore.Add(new Grade() { GradeName="DSADAW",Score = 2,StudentID = 1 });
            lstScore.Add(new Grade() { GradeName="SDADWDA",Score=8, StudentID = 1 });
            lstScore.Add(new Grade() { GradeName="SADAWDAD",Score=4,StudentID = 2 });
            lstScore.Add(new Grade() { GradeName = "SDADA", Score = 3, StudentID = 2 });
            lstScore.Add(new Grade() { GradeName="SDADWA",Score=-8, StudentID=2});
            lstScore.ForEach(s=>context.Grades.Add(s));
        }
    }
}
