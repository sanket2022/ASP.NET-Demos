using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class StudentBusinessLayer
    {
        public Student GetById(int StudentID)
        {
            Student student = new Student()
            {
                StudentID = StudentID,
                Name = "Rudy",
                Gender = "Male",
                Branch = "Nersery",
                Section = "Child School"
            };
            return student;
        }
        
    }
}