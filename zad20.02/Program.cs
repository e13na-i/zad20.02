namespace zad20._02
{
    internal class Program
    {

        static void InsertionSort(List<Student> students)
        {
            for (int i = 1; i < students.Count; i++)
            {
                var key = students[i];
                int j = i - 1;

                while (j >= 0 && (students[j].AvgGrade > key.AvgGrade || (students[j].AvgGrade == key.AvgGrade && string.Compare(students[j].Name, key.Name) > 0)))
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            var students = new List<Student>
        {
            new Student("Елинор", 5.50),
            new Student("Живко", 4.80),
            new Student("Виктория", 6.00),
            new Student("Иван", 5.50),
            new Student("Максим", 5.00)
        };

            InsertionSort(students);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
