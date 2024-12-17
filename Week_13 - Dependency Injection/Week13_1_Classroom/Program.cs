namespace Week13_1_Classroom
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            Teacher teacher = new Teacher
            {
                FirstName = "Mustafa",
                LastName = "Kemal"
            };

            ClassRoom classRoom = new ClassRoom(teacher);

            classRoom.GetTeacherInfo();

            Console.ReadKey();
        }
    }

    public interface ITeacher
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string GetInfo();
    }

    public class Teacher : ITeacher
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string GetInfo() 
        {
            return $"Öğretmen: {FirstName} {LastName}";
        }
    }

    public class ClassRoom
    {
        public readonly ITeacher _teacher;

        public ClassRoom(Teacher teacher)
        {
            _teacher = teacher;
        }

        public void GetTeacherInfo()
        {
            Console.WriteLine(_teacher.GetInfo());
        }
    }
}



