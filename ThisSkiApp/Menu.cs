////using System;
////using System.Collections.Generic;

////namespace Console_Menu
////{
////    class Program
////    {
////        private static int index = 0;

////        private static void Main(string[] args)
////        {
////            List<string> menuItems = new List<string>() {
////                "one",
////                "two",
////                "Exit"
////            };

////            Console.CursorVisible = false;
////            while (true)
////            {
////                string selectedMenuItem = drawMenu(menuItems);
////                if (selectedMenuItem == "one")
////                {
////                    Console.Clear();
////                    Console.WriteLine("ONE");
////                    Console.ReadLine();
////                }
////                if (selectedMenuItem == "two")
////                {
////                    Console.Clear();
////                    Console.WriteLine("TWO");
////                    Console.ReadLine();
////                }
////                else if (selectedMenuItem == "Exit")
////                {
////                    Environment.Exit(0);
////                }

////            }
////        }

////        private static string drawMenu(List<string> items)
////        {
////            Console.Clear();
////            for (int i = 0; i < items.Count; i++)
////            {
////                if (i == index)
////                {
////                    Console.BackgroundColor = ConsoleColor.Gray;
////                    Console.ForegroundColor = ConsoleColor.Black;
////                }

////                Console.WriteLine(items[i]);
////                Console.ResetColor();
////            }

////            ConsoleKeyInfo ckey = Console.ReadKey();

////            if (ckey.Key == ConsoleKey.DownArrow)
////            {
////                if (index == items.Count - 1)
////                {
////                    //index = 0; //Remove the comment to return to the topmost item in the list
////                }
////                else { index++; }
////            }
////            else if (ckey.Key == ConsoleKey.UpArrow)
////            {
////                if (index <= 0)
////                {
////                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
////                }
////                else { index--; }
////            }
////            else if (ckey.Key == ConsoleKey.Enter)
////            {
////                return items[index];
////            }
////            else
////            {
////                return "";
////            }

////            Console.Clear();
////            return "";
////        }
////    }
////}


//using System;

//namespace StringManipulation
//{
//    class SkiResortProgram
//    {
//        static void Main(string[] args)
//        {
//            bool showMenu = true;
//            while (showMenu)
//            {
//                showMenu = MainMenu();
//            }
//        }
//        public static bool MainMenu()
//        {
//            Console.Clear();
//            Console.WriteLine("Choose an option:Search ski resorts by ...");
//            Console.WriteLine("1) Colorado City");
//            Console.WriteLine("2) Resort name");
//            Console.WriteLine("3) Vertical drop");
//            Console.WriteLine("4) Exit");
//            Console.Write("\r\nSelect an option: ");

//            switch (Console.ReadLine())
//            {
//                case "1":
//                    QueryColoradoCity();
//                    return true;
//                case "2":
//                    QueryResortName();
//                    return true;
//                case "3":
//                    QueryVerticalDrop();
//                    return true;
//                case "4":
//                    return false;
//                default:
//                    return true;
//            }
//        }

//        internal class QueryColoradoCity
//        {
//            static void Main(string[] args)
//            {
//                //{
//                //    string filePath = @"Users/rannie/Projects/ColoradoSkiResorts/ColoradoSkiResorts/ColoradoSkiList.txt";

//                //    List<string> lines = File.ReadAllLines(filepath).ToList();

//                //    foreach (string line in lines)
//                //    {
//                //        Console.WriteLine(line);
//                //    }

//                //    lines.Add(ColoradoSkiResorts, City, VerticalDrop);
//                //    File.WriteAllLines(filepath, lines);
//                //    Console.ReadLine();
//                //}
              

//                static class QueryVerticalDrop()
//                {
//                    Console.Write("Enter the Colorado city you are interested in: ");
//                    return Console.ReadLine();
//                    Console.Clear();
//                    Console.WriteLine("Here are a list of resorts in");

//                    char[] charArray = CaptureInput().ToCharArray();
//            Array.Reverse(charArray);
//                    DisplayResult(String.Concat(charArray));
//        }
//        static class QueryResortName()
//            {
//                Console.Write("Enter the Colorado resort  you are interested in: ");
//                return Console.ReadLine();
//                Console.Clear();
//                Console.WriteLine("Here is information about that resort");

//                DisplayResult(CaptureInput().Replace(" ", ""));
//            }
//    static class QueryColoradoCity()
//            {
//                Console.Write("Enter the Colorado city you are interested in: ");
//                return Console.ReadLine();
//                Console.Clear();
//                Console.WriteLine("Here are a list of resorts in");

//                char[] charArray = CaptureInput().ToCharArray();
//    Array.Reverse(charArray);
//                DisplayResult(String.Concat(charArray));
//}

          
//       }

//            private static void DisplayResult(string message)
//{
//    Console.WriteLine($"\r\nYour modified string is: {message}");
//    Console.Write("\r\nPress Enter to return to Main Menu");
//    Console.ReadLine();
//}
//        }
//}