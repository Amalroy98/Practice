namespace StringsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello, World!");

            Student student = new Student();

            student.id = 123;
            student.name = "sajjad";
            student.age = 25;
            student.gender = 'M';
            student.Display();
            
            Student student2 = new Student();

            student2.id = 234;
            student2.name = "faris";
            student2.age = 25;
            student2.gender = 'M';
            student2.Display();

            //array of students

            Student[] students = new Student[3];
            students[0] = new Student() { id = 123, name = "nithin", age = 24, gender = 'm' };
            students[1] = new Student() { id = 133, name = "sajjad", age = 24, gender = 'm' };
            students[2] = new Student() { id = 999, name = "AMAL", age = 25, gender = 'm' };

            foreach(Student s in students)
                {
                s.Display() ;
            }


        }



    }
}
