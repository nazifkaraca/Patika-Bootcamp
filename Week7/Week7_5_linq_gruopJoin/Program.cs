namespace Week7_5_linq_gruopJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list takes Student and Classes classes as argument
            List<Students> students = new()
            {
                new Students(101, "Alice Smith", 1),
                new Students(102, "Bob Johnson", 2),
                new Students(103, "Carol White", 1),
                new Students(104, "Dave Brown", 3),
                new Students(105, "Eve Miller", 2),
            };

            List<Classes> classes = new()
            {
                new Classes(1, "Introduction to Programming"),
                new Classes(2, "Data Structures"),
                new Classes(3, "Web Development")
            };

            // Group Join classes with students by pairing 
            var classNstudents = classes.GroupJoin(students,
                                                   student => student.ClassId,
                                                   clas => clas.ClassId,
                                                   (classes, students) => new // Create new column names
                                                   {
                                                       ClassName = classes.ClassName,
                                                       Students = students
                                                   });

            Console.WriteLine();
            // Loop through new virtual table
            foreach (var clas in classNstudents)
            {
                Console.WriteLine();
                // Print ClassName from new table
                Console.WriteLine($"{clas.ClassName, 15}");
                Console.WriteLine("------------------------");
                
                // Loop nested table and print StudentName
                foreach (var student in clas.Students)
                {
                    Console.WriteLine($"- {student.StudentName}");
                }
            }
        }
    }
}
