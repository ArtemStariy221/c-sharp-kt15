using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Topics.IComparer.T1_StudentSorter
{
    public record Student(string LastName, int Age, double Gpa);

    public static class StudentSorter
    {
        public static IEnumerable<Student> Sort(IEnumerable<Student> students)
        {
            if (students == null || !students.Any())
                return Enumerable.Empty<Student>();

            return students.OrderBy(s => s, new StudentMultiComparer());
        }
    }

    public class StudentMultiComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            
            int lastNameComparison = string.Compare(x.LastName, y.LastName,
                StringComparison.OrdinalIgnoreCase);

            if (lastNameComparison != 0)
                return lastNameComparison;

      
            int ageComparison = y.Age.CompareTo(x.Age);
            if (ageComparison != 0)
                return ageComparison;

            return y.Gpa.CompareTo(x.Gpa);
        }
    }
}