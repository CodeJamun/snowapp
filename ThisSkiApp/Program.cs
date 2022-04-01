
//        //            //lines.Add("Resort,City,VD,Runs,Lifts")1;
//        //            //lines.Add("Arapahoe Basin,Dillon, 2530,147,9")2;
//        //            //lines.Add("Aspen Highlands,Aspen, 3635,117,5")3;
//        //            //lines.Add("Aspen Mountain,Aspen, 3267,	76,	8")4;
//        //            //lines.Add("Beaver Creek,Beaver Creek, 3340,150,23")5;
//        //            //lines.Add("Breckenridge,Breckenridge, 3398,87,	34")6;
//        //            //lines.Add("Buttermilk, Aspen,2030,44,8")7;
//        //            //lines.Add("Copper Mountain,Copper Mountain,2738,140, 24")8;
//        //            //lines.Add("Crested Butte,Crested Butte,2787,121,15")9;
//        //            //lines.Add("Echo Mountain,Evergreen,600,13, 3,")10;
//        //            //lines.Add("Eldora,Nederland,1400,63,10")11;
//        //            //lines.Add("Granby Ranch,Granby,1000,35,6")12;
//        //            //lines.Add("Hesperus,Hesperus,700,13,2,")13;
//        //            //lines.Add("Howelsen,Steamboat Springs,440,17,1")14;
//        //            //lines.Add("Kendall,Silverton,240,11,1")15;
//        //            //lines.Add("Keystone,Keystone,3128,128,20")16;
//        //            //lines.Add("Loveland,Dillon,2210,94,11")17;
//        //            //lines.Add("Monarch,Salida,1170,54,5")18;
//        //            //lines.Add("Powderhorn,Grand Junction,1650,50,4")19;
//        //            //lines.Add("Purgatory,Durango,2029,105,12")20;
//        //            //lines.Add("Silverton Mountain,Silverton,3087,69,1")21;
//        //            //lines.Add("Ski Cooper,Leadville,1200,60,5")22;
//        //            //lines.Add("Snowmass,Snowmass Village,4406,98,21")23;
//        //            //lines.Add("Steamboat,Steamboat Springs,3668,169,18")24;
//        //            //lines.Add("Sunlight,Glenwood Springs,2010,67,4")25;
//        //            //lines.Add("Telluride,Telluride,3790,148,17");26
//        //            //lines.Add("Vail,Vail,3450,195,31")27;
//        //            //lines.Add("Winter Park,Winter Park,3060,166,23")28;
//        //            //lines.Add("Wolf Creek,Pagosa Springs,1604,133,9")29;
//        //            //lines.Add("END OF LIST!");

//        //            //File.WriteAllLines(filePath, lines);

//        //            List<Resort> resorts = new List<Resort>();
//        //            List<string> lines = File.ReadAllLines(filePath).ToList();

//        //            foreach (var line in lines)
//        //            {
//        //                string[] entries = line.Split(',');
//        //                Resort newResort = new Resort();
//        //                newResort.Name = entries[0];
//        //                newResort.City = entries[1];
//        //              //  newResort.Vd = entries[2];
//        //                //  newResort.Runs = entries[3];
//        //                //   newResort.Lifts = entries[4];
//        //                resorts.Add(newResort);

//        //            }
//        //            foreach (var resort in resorts)
//        //            {
//        //                Console.WriteLine($"{resort.Name}, {resort.City}");
//        //            }
//        //            Console.ReadLine();


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoradoSKI
{
    class Program
    {
        public static List<Park> parks = new List<Park>();
        public static List<Resort> resorts = new List<Resort>();

        static void Main(string[] args)
        {
            InitializeParks();
            InitializeResorts();

            //SEARCH PARK NAME BY FIRST LETTER. Here we use "A"
            var queryLetter = from park in parks
                               where park.ParkName.StartsWith("A")
                               select park.ParkName;

            
            Console.WriteLine("HERE ARE SKI RESORTS THAT BEGIN WITH A:");
            Console.WriteLine('\n');

            foreach (var item in queryLetter)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\n');

            //ALPHABETICAL ORDER OF SKI RESORTS
            var queryAlphabetOrder = from park in parks
                               orderby park.ParkName
                               select park.ParkName;

            

            Console.WriteLine("Here is an alphabetical list of resorts:");
            Console.WriteLine('\n');
            foreach (var item in queryAlphabetOrder)
            {
                Console.WriteLine(item);
            }
      

            Console.WriteLine('\n');

            //ORDER BY increasing vertical distance (feet)

            var queryDrop = from park in parks
                               orderby park.Drop, park.ParkName descending
                               select park;
            
            Console.WriteLine("Here the resorts go higher and higher as you scroll down");
            Console.WriteLine('\n');
            foreach (var item in queryDrop)
            {
                Console.WriteLine(item.ParkName + ":" + item.Drop);
            }

      
            Console.WriteLine('\n');

            //Here is the first 6 of resorts
            var querykkkkkkkk = (from park in parks
                                select park).Take(6);

            Console.WriteLine("querykkkkkkkk");
            foreach (var item in querykkkkkkkk)
            {
                Console.WriteLine(item.ParkName);
            }

 

            Console.WriteLine('\n');

            //CONNECT RESORT AND PARK CLASSES
            var queryResortAndCity = from park in parks
                                join resort in resorts on park.ResortId equals resort.ResortId
                                select new { park.ParkName, resort.ResortCity };


            Console.WriteLine("**********************************");
            Console.WriteLine("Here are the Ski Resorts with their locations:");
            foreach (var item in queryResortAndCity)
            {
                Console.WriteLine(item.ParkName + ":" + item.ResortCity);
            }

            

        }
        ///////LIST OF ALL SKI RESORTS AND THEIR ATTRIBUTES

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
  