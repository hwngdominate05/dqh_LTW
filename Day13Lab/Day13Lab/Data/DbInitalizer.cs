using Microsoft.EntityFrameworkCore;
using Day13Lab.Models;

namespace Day13Lab.Data
{
    public class DbInitalizer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SchoolContext(serviceProvider
                .GetRequiredService<DbContextOptions<SchoolContext>>()))
            {
                context.Database.EnsureCreated();
                if (context.Majors.Any())
                {
                    return;
                }
                var majors = new Major[]
                {
                    new Major{MajorName="IT"},
                    new Major{MajorName="Economics"},
                    new Major{MajorName="Mathmatics"}
                };
                foreach(var major in majors)
                {
                    context.Majors.Add(major);
                }
                context.SaveChanges();
                var learnerss = new Learner[]
                {
                    new Learner{FirstMidName="John",LastName="Doe",EnrollmentDate=DateTime.Parse("2020-09-01"),MajorID= 1},
                    new Learner{FirstMidName="Sam",LastName="Brown",EnrollmentDate=DateTime.Parse("2021-09-01"),MajorID= 2}
                };
                foreach (Learner learners in learnerss)
                {
                    context.Learners.Add(learners);
                }
                context.SaveChanges();
                var courses = new Course[]
                {
                    new Course{CourseID=1050,Title="Chemistry" ,Credits=3},
                    new Course{CourseID=4022,Title="Microeconomics" ,Credits=3},
                    new Course{CourseID=4041,Title="Macroeconomics" ,Credits=3}
                };

                foreach (Course course in courses)
                {
                    context.Courses.Add(course);
                }
                context.SaveChanges();
                var enrollments = new Enrollment[]
                {
                    new Enrollment{LearnerID=1,CourseID=1050,Grade=5.5f},
                    new Enrollment{LearnerID=1,CourseID=4022,Grade=7.5f},
                    new Enrollment{LearnerID=2,CourseID=4041,Grade=3.5f},
                    new Enrollment{LearnerID=3,CourseID=1050,Grade=7f}
                };
                foreach (Enrollment enrollment in enrollments)
                {
                    context.Enrollments.Add(enrollment);
                }
                context.SaveChanges();
            }
        }
    }
}
