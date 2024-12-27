namespace Assignment01
{
    internal class Program
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

        enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        [Flags]
        enum Permissions
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        enum Colors
        {
            Red,
            Green,
            Blue
        }
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Days of the Week:");
            //for (int i = (int)WeekDays.Monday; i <= (int)WeekDays.Sunday; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter a season name: ");
            //string input = Console.ReadLine();
            //switch (input)
            //{
            //    case "spring":
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case "summer":
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case "autumn":
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case "winter":
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid season name.");
            //        break;
            //}
            #endregion

            #region Q3
            //Permissions Permission = (Permissions)3;
            //Permission ^= Permissions.Delete; 
            //Console.WriteLine("Permissions after adding Delete: " + Permission);
            //Permission ^= Permissions.Read;
            //Console.WriteLine("Permissions after removing Read: " + Permission);
            //if((Permission & Permissions.Write) == Permissions.Write)Console.WriteLine("Yes..Write Permission exist");
            //else Console.WriteLine("NO..Write Permission does't exist");
            #endregion

            #region Q4
            //Console.WriteLine("Enter a color name:");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(input, out Colors color))
            //{
            //    if (color == Colors.Blue || color == Colors.Red || color == Colors.Green)
            //        Console.WriteLine(color + " is a primary color.");
            //}
            //else Console.WriteLine(input + " isn't a primary color.");
            #endregion
        }

    }

}
