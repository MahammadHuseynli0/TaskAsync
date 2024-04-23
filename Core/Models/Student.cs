using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {

        private static int _id;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Grade { get; set; }
        public int StudentPoint { get; set; }
        public Student(string name, string surname, double grade, int studentPoint )
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Grade = grade;
            StudentPoint = studentPoint;
        }









    }
}
