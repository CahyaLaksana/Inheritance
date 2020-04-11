using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string Name, int Age)
       {
           this.Name = Name;
           this.Age = Age; 
       }
        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
        }
       
    }
        public class Teacher : Person
        {
            public string TeacherId  { get; set; }

            public string Subject { get; set; }
             public Teacher(string Name, int Age, string TeacherId, string Subject)
                 :base(Name, Age)
                 {
                     this.TeacherId = TeacherId;
                     this.Subject = Subject;
                 }
                 
        
        }
        public class Student : Person
        {
            public string StudentId { get; set; }

            public string Email  { get; set; }
        public Student(string Name, int Age, string StudentId, string Email)
             :base(Name, Age)
            {
                this.StudentId = StudentId;
                this.Email = Email;
            }
        }
        

        class Program
    {
        static void Main(string[] args)
        {
                Person person   = new Person("Bagong", 39);
                person.GetNameAndAge();

                Teacher teacher     = new Teacher("Jerry", 35, "98765", "English");
                teacher.GetNameAndAge();

                Student student    = new Student("Sampho", 16, "123456", "Sampho@pantene.sph");
                student.GetNameAndAge();

                Console.ReadKey();


     

        }
    }
}

