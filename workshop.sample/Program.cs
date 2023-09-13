namespace workshop.sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Teacher ****************");

            Teacher t1 = new Teacher();
            t1.FirstName =  "nigel";
            t1.Dob = new DateTime(1975, 1, 3);


            Console.WriteLine(t1.FirstName);

            Console.WriteLine(t1.Age(true));


            Console.WriteLine("********** Student ****************");

            Student s1 = new Student();

            Console.WriteLine(s1.FavDrink());

            Console.WriteLine(s1.Subject);



            Console.WriteLine("********** Course ****************");

            Course csharpCourse = new Course("C#", t1);
            
            csharpCourse.Students.Add(s1);
            csharpCourse.Students.Add(new Student() { Name = "Annefleur" });

            Console.WriteLine(csharpCourse.Name);
            Console.WriteLine(csharpCourse.CourseTeacher.FirstName);
            Console.WriteLine(csharpCourse.CourseTeacher.Age(true));
        }
    }
}