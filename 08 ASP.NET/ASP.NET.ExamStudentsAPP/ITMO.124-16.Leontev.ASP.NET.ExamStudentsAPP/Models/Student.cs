using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO._124_16.Leontev.ASP.NET.ExamStudentsAPP.Models
{
    public class Student
    {
        // ID студента
        public virtual int StudentId { get; set; }
        // ФИО студента
        public virtual string StudentName { get; set; }
        // Номер документа (паспорт)
        public virtual int PassportNumber { get; set; }
        // Технологии программирования
        public virtual int TechProg { get; set; }
        // Введение в базы данных
        public virtual int DBBegin { get; set; }
        // Программирование на C#
        public virtual int CSProg { get; set; }
        // Transact-SQL
        public virtual int TSQL { get; set; }
        // Разработка Windows-приложений на C#
        public virtual int CSDev { get; set; }
    }
}