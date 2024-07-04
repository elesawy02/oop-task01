using oop_task01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static oop_task01.Program;

namespace oop_task01
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    public enum Permission
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    public class PermissionManager
    {
        public Permission Permissions { get; private set; }

        public PermissionManager(Permission initialPermissions = Permission.Delete)
        {
            Permissions = initialPermissions;
        }

        public void AddPermission(Permission permissionToAdd)
        {
            Permissions |= permissionToAdd;
        }

        public void RemovePermission(Permission permissionToRemove)
        {
            Permissions &= ~permissionToRemove;
        }

        public bool HasPermission(Permission permissionToCheck)
        {
            return (Permissions & permissionToCheck) == permissionToCheck;
        }
    }
    internal class Program
    {
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        public struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            static void Main(string[] args)
            {
                #region Q01: Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.


                //Console.WriteLine("Days of the week:");
                //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
                //{
                //    Console.WriteLine(day);
                //}
                #endregion





                #region Q02:Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
                //Person[] persons = new Person[3]:
                //persons[0] = new Person("mahmoud", 25);
                //persons[1] = new Person("eslam", 34);
                //persons[2] = new Person("ahmed", 35);

                //// Display the details of all the persons in the array
                //foreach (Person person in persons)
                //{
                //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            #endregion



            #region Q03:Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //        Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            //        string input = Console.ReadLine();

            //        if (Enum.TryParse(input, true, out Season season))
            //        {
            //            string months = GetSeasonMonths(season);
            //        Console.WriteLine($"The months for {season} are: {months}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid season name. Please enter one of the following: Spring, Summer, Autumn, Winter.");
            //        }
            //static string GetSeasonMonths(Season season)
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            return "March to May";
            //        case Season.Summer:
            //            return "June to August";
            //        case Season.Autumn:
            //            return "September to November";
            //        case Season.Winter:
            //            return "December to February";
            //        default:
            //            throw new ArgumentOutOfRangeException();



            #endregion


            //#region Q03 :Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //        Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable


            //        permmisions userPermissions = permmisions.None;


            //        userPermissions |= Permissions.Read;
            //        userPermissions |= Permissions.Write;

            //        Console.WriteLine($"Current permissions: {userPermissions}");

            //        // Check if specific permission exists
            //        if ((userPermissions & Permissions.Read) == Permissions.Read)
            //        {
            //            Console.WriteLine("Read permission is granted.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Read permission is not granted.");
            //        }

            //if ((userPermissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete permission is granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Delete permission is not granted.");
            //}

            //// Remove a permission
            //userPermissions &= ~Permissions.Write;

            //// Display current permissions after removal
            //Console.WriteLine($"Current permissions after removal: {userPermissions}");

            //// Check if the Write permission exists after removal
            //if ((userPermissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write permission is granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Write permission is not granted.");
            //}


            //        #endregion



            #region Q04:Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.


            //    Console.WriteLine("Enter the X coordinate of the first point:");
            //    double x1 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter the Y coordinate of the first point:");
            //    double y1 = Convert.ToDouble(Console.ReadLine());

            //    Point point1 = new Point(x1, y1);

            //    Console.WriteLine("Enter the X coordinate of the second point:");
            //    double x2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter the Y coordinate of the second point:");
            //    double y2 = Convert.ToDouble(Console.ReadLine());

            //    Point point2 = new Point(x2, y2);

            //    double distance = CalculateDistance(point1, point2);

            //    Console.WriteLine($"The distance between the two points is {distance}");
            //}

            //public static double CalculateDistance(Point p1, Point p2)
            //{
            //    double deltaX = p1.X - p2.X;
            //    double deltaY = p1.Y - p2.Y;
            //    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            #endregion


            #region Q05:Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

//            Person[] persons = new Person[3];

//        for (int i = 0; i< 3; i++)
//        {
//            Console.WriteLine($"Enter the name of person {i + 1}:");
//            string name = Console.ReadLine();

//            Console.WriteLine($"Enter the age of person {i + 1}:");
//            int age = Convert.ToInt32(Console.ReadLine());

//            persons[i] = new Person(name, age);
//        }

//        Person oldestPerson = persons[0];
//        for (int i = 1; i<persons.Length; i++)
//        {
//            if (persons[i].Age > oldestPerson.Age)
//            {
//                oldestPerson = persons[i];
//            }
//}

//Console.WriteLine($"The oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}");
    
            #endregion

        }

    }
}
