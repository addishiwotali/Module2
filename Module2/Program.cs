namespace Module2;
using System.Collections.Generic; 

class Program
{
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            
            Student student1 = new Student();
            student1.Name = "Marry";
            student1.ID = 1;
            
            Student student2 = new Student
            {
                Name = "Bethy",
                ID = 2
            };
            
            Student student3 = new Student
            {
                Name = "Micheal",
                ID = 3
            };
            
            Student student4 = new Student();
            student4.Name = "Mercy";
            student4.ID = 4;
            
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            

            Student.AddGrade(student1, 94.3);
            Student.AddGrade(student1, 90.0, 78.9, 95.4);

            Student.AddGrade(student2, 88.5);
            Student.AddGrade(student2, 92.0, 85.4);

            Student.AddGrade(student3, 76.2);
            Student.AddGrade(student3, 80.0, 82.3, 79.9);

            Student.AddGrade(student4, 91.0);
            Student.AddGrade(student4, 89.5, 93.2);

            
            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student.ID}");
                Console.WriteLine($"Name: {student.Name}");
                Console.Write("Grades: ");

                
                foreach (double grade in student.Grades)
                {
                    Console.Write($"{grade} ");
                }
                
                double average = Student.CalculateAverageGrade(student);
                Console.WriteLine($"\nAverage Grade: {average:F2}");
                Console.WriteLine("-----------------------------------");
            }

            
        }
    }


    
