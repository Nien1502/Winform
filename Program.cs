using System;
using System.Collections.Generic;
using System.Linq;

namespace Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student(1,"Loc",18);
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "An", 20));
            students.Add(new Student(2, "Phu", 21));
            students.Add(new Student(3, "Manh", 16));
            students.Add(new Student(4, "Hai", 15));
            students.Add(new Student(5, "Anh", 19));
            Console.WriteLine("Danh sach hoc sinh: ");
            
            students.ForEach(student => Console.WriteLine(student));
            var ds = students.Where(student => student.Age >= 15 && student.Age <= 18).ToList();
            Console.WriteLine("Danh sach hoc sinh tuoi tu 15 den 18: ");
            ds.ForEach(student => Console.WriteLine(student));
            Console.WriteLine("Danh sach hoc sinh co ten bat dau bang chu A: ");
            var find = students.Where(student => student.Name.StartsWith("A")).ToList();
            find.ForEach(student => Console.WriteLine(student));
            Console.Write("Tong tuoi: ");
            int tongTuoi = students.Sum(student => student.Age);
            Console.WriteLine(tongTuoi);
            Console.WriteLine("Hoc sinh co tuoi lon nhat:");
            int find2 = students.Max(s => s.Age);
            Student st = students.FirstOrDefault(s => s.Age == find2);
            Console.WriteLine(st);
            Console.WriteLine("danh sach hoc sinh co tuoi tang dan:");
            var ds2 = students.OrderBy(s => s.Age).ToList();
            ds2.ForEach(student => Console.WriteLine(student));
            Console.ReadLine();
        }
    }
}