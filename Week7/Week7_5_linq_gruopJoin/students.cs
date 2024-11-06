using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_5_linq_gruopJoin
{
    public class Students
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }

        public Students(int studentId, string studentName, int classId)
        {
            StudentId = studentId;
            StudentName = studentName;
            ClassId = classId;
        }
    }

    public class Classes
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public Classes(int classId, string className)
        {
            ClassId = classId;
            ClassName = className;
        }
    }
}
