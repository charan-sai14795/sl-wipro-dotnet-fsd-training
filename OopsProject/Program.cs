using System;
using System.Collections.Generic;
using System.IO;
namespace OopsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string oneclass = @"C:\Users\chara\Desktop\OneClass";
            string student = @"C:\Users\chara\Desktop\Student";
            string subject = @"C:\Users\chara\Desktop\Subject";
            string []OneClass=File.ReadAllLines(oneclass);
            string[] Student = File.ReadAllLines(student);
            string[] Subject = File.ReadAllLines(subject);
            List<OneClass>l1 = new List<OneClass>();
            List<Student>l2 = new List<Student>();
            List<Subject>l3 = new List<Subject>();

        }
    }
}