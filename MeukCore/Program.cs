using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MeukCore
{
    class Program
    {
        public record Person(string FirstName, string LastName)
        {
            public string[] PhoneNumbers { get; init; }
        }

        //public abstract record Person(string FirstName, string LastName);
        public record Teacher(string FirstName, string LastName, int Grade)
            : Person(FirstName, LastName);

        static void AccedModIn(in int i)
        {
            Console.WriteLine("in");
            //i++;
        }

        static void AccedModIn( int i)
        {
            Console.WriteLine("without");
            i++;
        }

        public static ref int Find(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return ref matrix[i, j];
            throw new InvalidOperationException("Not found");
        }

        private List<int> ls = new();

        public static bool IsLetter(this char c) =>
            c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        static void Main(string[] args)
        {
            var originValue = Point3D.Origin;
            ref readonly var originReference = ref Point3D.Origin;

            {
                using var book1 = new Book();
            }
            
            using var book = new Book();


            int i = 42;
            AccedModIn(in i);
            AccedModIn(i);

            Person person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);

            Func<double, double> square = static x => x * x;

            square(2d);

            Debugger.Break();
        }
    }

    /// <summary>
    /// Ref struct with dispose!!
    /// </summary>
    ref struct Book
    {
        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
}
