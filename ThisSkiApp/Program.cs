//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace ColoradoSKI
//{
//    class Program
//    {
//        //static void Main(string[] args)
//        //{
//        //            string filePath = @"/Users/rannie/Desktop/ResortListFolder/ResortList.txt";
//        //            //List<string> lines = File.ReadAllLines(filePath).ToList();

//        //            //foreach(string line in lines)
//        //            //{
//        //            //    Console.WriteLine(line);
//        //            //}
//        //            //lines.Add("Resort,City,VD,Runs,Lifts");
//        //            //lines.Add("Arapahoe Basin,Dillon, 2530,147,9");
//        //            //lines.Add("Aspen Highlands,Aspen, 3635,117,5");
//        //            //lines.Add("Aspen Mountain,Aspen, 3267,	76,	8");
//        //            //lines.Add("Beaver Creek,Beaver Creek, 3340,150,23");
//        //            //lines.Add("Breckenridge,Breckenridge, 3398,87,	34");
//        //            //lines.Add("Buttermilk, Aspen,2030,44,8");
//        //            //lines.Add("Copper Mountain,Copper Mountain,2738,140, 24");
//        //            //lines.Add("Crested Butte,Crested Butte,2787,121,15");
//        //            //lines.Add("Echo Mountain,Evergreen,600,13, 3,");
//        //            //lines.Add("Eldora,Nederland,1400,63,10");
//        //            //lines.Add("Granby Ranch,Granby,1000,35,6");
//        //            //lines.Add("Hesperus,Hesperus,700,13,2,");
//        //            //lines.Add("Howelsen,Steamboat Springs,440,17,1");
//        //            //lines.Add("Kendall,Silverton,240,11,1");
//        //            //lines.Add("Keystone,Keystone,3128,128,20");
//        //            //lines.Add("Loveland,Dillon,2210,94,11");
//        //            //lines.Add("Monarch,Salida,1170,54,5");
//        //            //lines.Add("Powderhorn,Grand Junction,1650,50,4");
//        //            //lines.Add("Purgatory,Durango,2029,105,12");
//        //            //lines.Add("Silverton Mountain,Silverton,3087,69,1");
//        //            //lines.Add("Ski Cooper,Leadville,1200,60,5");
//        //            //lines.Add("Snowmass,Snowmass Village,4406,98,21");
//        //            //lines.Add("Steamboat,Steamboat Springs,3668,169,18");
//        //            //lines.Add("Sunlight,Glenwood Springs,2010,67,4");
//        //            //lines.Add("Telluride,Telluride,3790,148,17");
//        //            //lines.Add("Vail,Vail,3450,195,31");
//        //            //lines.Add("Winter Park,Winter Park,3060,166,23");
//        //            //lines.Add("Wolf Creek,Pagosa Springs,1604,133,9");
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

            //WHERE
            var querySyntax1 = from park in parks
                               where park.ParkName.StartsWith("A")
                               select park.ParkName;

            Console.WriteLine("Where in querySyntax------");
            foreach (var item in querySyntax1)
            {
                Console.WriteLine(item);
            }

            var methodSyntax1 = parks.Where(e => e.ParkName.StartsWith("A"));
            Console.WriteLine("Where in methodSyntax-----");
            foreach (var item in methodSyntax1)
            {
                Console.WriteLine(item.ParkName);
            }

            Console.WriteLine('\n');


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
            }
        }
    }
  