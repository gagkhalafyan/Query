
using Linq_Tasks;

class Program
{
    static void Main()
    {
    
        var students = new List<(int Id, string Name)>
    {
       (1, "Alice"),
       (2, "Bob"),
       (3, "Charlie")
    };

        var enrollments = new List<(int StudentId, int CourseId)>
    {
    (1, 101),
    (1, 102),
    (2, 102),
    (3, 103)
    };


        var courses = new List<(int CourseId, string CourseName, int Difficulty)>
    {
    (101, "Math", 4),
    (102, "Science", 3),
    (103, "History", 2)
    };

        var assignments = new List<(int StudentId, string AssignmentName, int Score)>
    {
    (1, "Math HW1", 85),
    (1, "Math HW2", 90),
    (2, "Science HW1", 75),
    (2, "Science HW2", 70),
    (3, "History HW1", 95)
    };

        var submissions = new List<(int StudentId, string AssignmentName)>
{
    (1, "Math HW1"),
    (1, "Math HW2"),
    (2, "Science HW1")
};

        //Task 1

        var res1 = (from student in students
                   join enrolment in enrollments
                   on student.Id equals enrolment.StudentId
                   join course in courses
                   on enrolment.CourseId equals course.CourseId
                   where course.Difficulty > 3
                   orderby student.Name
                   select new
                   {
                       StudentName = student.Name,
                       CourseName = course.CourseName,
                       Difficulty = course.Difficulty,
                   }).ToList();


        foreach (var item in res1)
        {
            Console.WriteLine($"{item.StudentName} is enrolled in {item.CourseName} (Difficulty:[{item.Difficulty}])");
        }

        Console.WriteLine();

        //Task 2

        var res2 = (from student in students
                    join assignment in assignments
                    on student.Id equals assignment.StudentId
                    where assignment.Score > 80
                    select new
                    {
                        StudentName = student.Name,
                        StudentGrade = (assignment.Score)
                    }).ToList();

        foreach(var item in res2)
        {
            Console.WriteLine($"{item.StudentName} {item.StudentGrade}");
        }

        Console.WriteLine();

        //Task 3

        var res3 = from student in students
                   join submission in submissions
                   on student.Id equals submission.StudentId
                   select new
                   {
                       StudentName = student.Name,
                       submission.StudentId
                   };
        foreach (var item in res3)
        {
            Console.WriteLine(item);
        }
    }
}