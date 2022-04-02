//**************************************************
// File Name:        ThisSkiApp
// Version:          1.0
// Description:      Return attributes from Colorado Ski Resort List
// Last Modified:    April 2022
//**************************************************



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoradoSKI

{
    class Program

    {
        public static List<Park> parks = new List<Park>();
        public static List<Resort> resorts = new List<Resort>();



        public static void Main(string[] args)
        {
            InitializeParks();
            InitializeResorts();


            Console.WriteLine("█░█░█ █▀▀ █░░ █▀▀ █▀█ █▀▄▀█ █▀▀   ▀█▀ █▀█   ▀█▀ █░█ █▀▀   █▀ █▄▀ █   ▄▀█ █▀█ █▀█");
            Console.WriteLine("▀▄▀▄▀ ██▄ █▄▄ █▄▄ █▄█ █░▀░█ ██▄   ░█░ █▄█   ░█░ █▀█ ██▄   ▄█ █░█ █   █▀█ █▀▀ █▀▀");

            Console.WriteLine('\n');


            //SEARCH PARK NAME BY FIRST LETTER. Here we use USER INPUT
            {
                char ch;
                bool result;

                //input character 
                Console.Write("Search Ski resort park names(Enter capital letter A, B, C, E, or G)-->");
                result = Char.TryParse(Console.ReadLine(), out ch);


                //printing the input character
                Console.WriteLine("result is: {0}", result);
                Console.WriteLine("You picked the letter {0}. Please press enter to continue", ch);

                //hit ENTER to exit the program
                Console.ReadLine();


                var queryLetter = from park in parks
                                  where park.ParkName.StartsWith(ch)
                                  select park.ParkName;



                Console.WriteLine("HERE ARE SKI RESORTS THAT BEGIN WITH {0}", ch);
                Console.WriteLine('\n');

                foreach (var item in queryLetter)
                {
                    Console.WriteLine("*********************");
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("*********************");
            Console.WriteLine('\n');


            //ALPHABETICAL ORDER OF SKI RESORTS

            Console.WriteLine("Press 'y' if you would like an alphabetical list of resorts! Press 'n' if you would like to exit the app");

            ConsoleKeyInfo key1 = Console.ReadKey();

            if (key1.KeyChar.ToString() == "y")

            //USER PICKED YES FOR ALPHABETICAL LIST
            {
                var queryAlphabetOrder = from park in parks
                                         orderby park.ParkName
                                         select park.ParkName;


                {
                    Console.WriteLine('\n');
                    Console.WriteLine("█▀█ █▀▀ █▀ █▀█ █▀█ ▀█▀ █▀   ▄▀ ▄▀█ █░░ █▀█ █░█ ▄▀█ █▄▄ █▀▀ ▀█▀ █ █▀▀ ▄▀█ █░░ ▀▄");
                    Console.WriteLine("█▀▄ ██▄ ▄█ █▄█ █▀▄ ░█░ ▄█   ▀▄ █▀█ █▄▄ █▀▀ █▀█ █▀█ █▄█ ██▄ ░█░ █ █▄▄ █▀█ █▄▄ ▄▀");
                    Console.WriteLine('\n');
                    foreach (var item in queryAlphabetOrder)

                        Console.WriteLine(item);
                }


                Console.WriteLine('\n');

            }
            else
            {

                // Exit console app
                Console.WriteLine('\n');

                Console.WriteLine("You chose to exit the app.  Thanks for visiting the SkiApp");
                System.Environment.Exit(1);
            }

            //ORDER BY increasing vertical distance (feet)

            Console.WriteLine("Press 'y' if you would like a list of resorts with their vertical drop? Press 'n' if you would like to exit the app");

            ConsoleKeyInfo key2 = Console.ReadKey();

            if (key2.KeyChar.ToString() == "y")

            //USER PICKED YES FOR VERTICAL DISTANCE
            {
                { 
            
                    Console.WriteLine('\n');
                    Console.WriteLine("Here's fun facts about how high the resorts go!");
                    //ORDER BY increasing vertical distance (feet)

                    var queryDrop = from park in parks
                                    orderby park.Drop, park.ParkName descending
                                    select park;

                    Console.WriteLine("█░█ █▀▀ █▀█ ▀█▀ █ █▀▀ ▄▀█ █░░   █▀▄ █▀█ █▀█ █▀█");
                    Console.WriteLine("▀▄▀ ██▄ █▀▄ ░█░ █ █▄▄ █▀█ █▄▄   █▄▀ █▀▄ █▄█ █▀▀");
                    Console.WriteLine('\n');
                    foreach (var item in queryDrop)
                    {
                        Console.WriteLine(item.ParkName + ":" + item.Drop);
                    }


                }


                Console.WriteLine('\n');



                //Conversion from meters from feet
                Console.WriteLine("Now we have all these measurements, let's find out the meter conversion!");
                double meter, feet;
                Console.WriteLine("Enter feet :");

                feet = Convert.ToInt32(Console.ReadLine());
                meter = feet / 3.2808399;
                Console.WriteLine("Now you're ready for European ski resorts ^_^" + "\nFeet to meter : " + meter);
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();

            }
             else
            {

                // Exit console app
                Console.WriteLine('\n');

                Console.WriteLine("You chose to exit the app.  Thanks for visiting the SkiApp");
                System.Environment.Exit(1);
            }


            //Here is the first 6 of resorts

            Console.WriteLine("Press 'y' if you would like a list of the first 6 resorts with their cities? Press 'n' if you would like to exit the app");

            ConsoleKeyInfo key3 = Console.ReadKey();
            if (key3.KeyChar.ToString() == "y")
            {
                Console.WriteLine('\n');
                Console.WriteLine('\n');
                var queryRandom = (from resort in resorts
                                   select resort).Take(6);

                Console.WriteLine("Here's the top resort cities");
                foreach (var item in queryRandom)
                {
                    Console.WriteLine(item.ResortCity);
                }
            }

            else
            {
                // Exit console app
                Console.WriteLine('\n');

                Console.WriteLine("You chose to exit the app.  Thanks for visiting the SkiApp");
                System.Environment.Exit(1);
            }


            Console.WriteLine('\n');

            //CONNECT RESORT AND PARK CLASSES
            var queryResortAndCity = from park in parks
                                     join resort in resorts on park.ResortId equals resort.ResortId
                                     select new { park.ResortId, park.ParkName, resort.ResortCity };


            Console.WriteLine('\n');

            Console.WriteLine("█▀█ █▀▀ █▀ █▀█ █▀█ ▀█▀   █░░ █▀█ █▀▀ ▄▀█ ▀█▀ █ █▀█ █▄░█ █▀");
            Console.WriteLine("█▀▄ ██▄ ▄█ █▄█ █▀▄ ░█░   █▄▄ █▄█ █▄▄ █▀█ ░█░ █ █▄█ █░▀█ ▄█");

            foreach (var item in queryResortAndCity)
            {
                Console.WriteLine(item.ParkName + ":" + item.ResortCity);
            }

            {

                //Write files to external text file
                string[] lines = { "Here are the remaining resorts: Hesperus, Howelsen,Steamboat Springs,440/ Kendall,Silverton,240/Keystone,Keystone,3128/Loveland,Dillon,2210 " +
                        "Monarch,Salida,1170/Powderhorn,Grand Junction,1650/Purgatory,Durango,2029 " +
                        "/Silverton Mountain,Silverton,3087/Ski Cooper,Leadville,1200/Snowmass,Snowmass Village,4406"+
                 "Steamboat,Steamboat Springs,3668/Sunlight,Glenwood Springs,2010/Telluride,Telluride,3790/Vail,Vail,3450"+
                 "Winter Park,Winter Park,3060/Wolf Creek,Pagosa Springs,1604"+"END OF LIST! "};

                try
                {
                    System.IO.File.WriteAllLines(@"D:\lines.txt", lines);

                    Console.WriteLine("You have saved an external file with the remaining resorts.  (Lines written to file successfully). Please check your D drive.");
                    Console.WriteLine("You have exited the program");
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }

        }


        ///////LIST OF ALL SKI RESORTS AND THEIR ATTRIBUTES///////

        public static void InitializeParks()
        {
            parks.Add(new Park
            {

                ResortId = 1,
                Drop = 2530,
                ParkName = "Arapahoe Basin",

            });

            parks.Add(new Park
            {
                ResortId = 2,
                Drop = 3635,
                ParkName = "Aspen Highlands",

            });

            parks.Add(new Park
            {
                ResortId = 3,
                Drop = 3267,
                ParkName = "Aspen Mountain",
            });

            parks.Add(new Park
            {
                ResortId = 4,
                Drop = 3340,
                ParkName = "Beaver Creek",
            });

            parks.Add(new Park
            {
                ResortId = 5,
                Drop = 3398,
                ParkName = "Breckenridge",

            });

            parks.Add(new Park
            {
                ResortId = 6,
                Drop = 2030,
                ParkName = "Buttermilk",

            });
            parks.Add(new Park
            {
                ResortId = 7,
                Drop = 2738,
                ParkName = "Copper Mountain",

            });
            parks.Add(new Park
            {
                ResortId = 8,
                Drop = 2787,
                ParkName = "Crested Butte",

            });
            parks.Add(new Park
            {
                ResortId = 9,
                Drop = 600,
                ParkName = "Echo Mountain",

            });
            parks.Add(new Park
            {
                ResortId = 10,
                Drop = 1400,
                ParkName = "Eldora",

            });
            parks.Add(new Park
            {
                ResortId = 11,
                Drop = 1000,
                ParkName = "Granby Ranch",

            });

        }

        public static void InitializeResorts()
        {
            resorts.Add(new Resort
            {
                ResortId = 1,
                ResortCity = "Dillon"

            });

            resorts.Add(new Resort
            {
                ResortId = 2,
                ResortCity = "Aspen"

            });

            resorts.Add(new Resort
            {
                ResortId = 3,
                ResortCity = "Aspen"

            });

            resorts.Add(new Resort
            {
                ResortId = 4,
                ResortCity = "Beaver Creek"

            });

            resorts.Add(new Resort
            {
                ResortId = 5,
                ResortCity = "Breckenridge"

            });

            resorts.Add(new Resort
            {
                ResortId = 6,
                ResortCity = "Aspen"

            });
            resorts.Add(new Resort
            {
                ResortId = 7,
                ResortCity = "Copper Mountain"

            });
            resorts.Add(new Resort
            {
                ResortId = 8,
                ResortCity = "Crested Butte"

            });

            resorts.Add(new Resort
            {
                ResortId = 9,
                ResortCity = "Evergreen"

            });

            resorts.Add(new Resort
            {
                ResortId = 10,
                ResortCity = "Nederland"

            });

            resorts.Add(new Resort
            {
                ResortId = 11,
                ResortCity = "Granby"

            });
        }
    }
}