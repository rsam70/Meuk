using System;

#nullable enable

// at project file <Nullable>enable</Nullable>

namespace MeukCore2
{
    public struct Student
    {
        public string FirstName;
        public string? MiddleName;
        public string LastName;
    }

    public struct Coords<T>
    {
        public T X;
        public T Y;
        //string s;
    }

    class Program
    {
        //string? name;

        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"First name: {student.FirstName.ToUpper()}");
            //Console.WriteLine($"Middle name: {student.MiddleName.ToUpper()}");
            Console.WriteLine($"Last name: {student.LastName.ToUpper()}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrintStudent(default);

            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };

            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"

            Console.WriteLine(lastPhrase);

            var range = 1..4;

            Span<Coords<int>> coordinates = stackalloc[]
{
                new Coords<int> { X = 0, Y = 0 },
                new Coords<int> { X = 0, Y = 3 },
                new Coords<int> { X = 4, Y = 0 }
            };
        }
    }
}
