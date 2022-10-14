using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO._124_16.Leontev.ASP.NET.ExamStudentsAPP.Models
{
    public class StudentsDbInitializer : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            context.Students.Add(new Student
            {
                StudentName = "Иванов Иван Иванович",
                PassportNumber = 1111,
                TechProg = 5,
                DBBegin = 5,
                CSProg = 5,
                TSQL = 5,
                CSDev = 5
            });
            context.Students.Add(new Student
            {
                StudentName = "Петров Петр Петрович",
                PassportNumber = 2222,
                TechProg = 4,
                DBBegin = 4,
                CSProg = 4,
                TSQL = 4,
                CSDev = 4
            });
            context.Students.Add(new Student
            {
                StudentName = "Сидоров Сидор Сидорович",
                PassportNumber = 3333,
                TechProg = 3,
                DBBegin = 3,
                CSProg = 3,
                TSQL = 3,
                CSDev = 3
            });

            base.Seed(context);
        }
    }
}