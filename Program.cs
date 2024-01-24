using Amazon.Runtime.Internal.Util;
using EscapeFromTheWoods.Database.MongoDB;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace EscapeFromTheWoods
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Hello World!");
            //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=monkeys;Integrated Security=True";
            //DBwriter db = new DBwriter(connectionString);
            string connectionString = @"mongodb://localhost:27017";
            string mongoDatabaseName = "monkeys";
            DBWriterMDB mdb = new DBWriterMDB(connectionString, mongoDatabaseName);

            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("LogFile.txt")
            .CreateLogger();

            string path = @"C:\Users\frede\Documents\Gent\Jaar 2\Refactoring Eindopdracht\bitmapimages";





            List<Task> tasks1 = new List<Task>();
            Map m1 = new Map(0, 500, 0, 500);


            WoodBuilder woodBuilder1 = new WoodBuilder();

            Wood w1 = await woodBuilder1.GetWood(500, m1, path, mdb);



            //tasks1.Add(w1.PlaceMonkey("Alice", IDgenerator.GetMonkeyID()));
            //tasks1.Add(w1.PlaceMonkey("Janice", IDgenerator.GetMonkeyID()));
            //tasks1.Add(w1.PlaceMonkey("Toby", IDgenerator.GetMonkeyID()));
            //tasks1.Add(w1.PlaceMonkey("Mindy", IDgenerator.GetMonkeyID()));
            //tasks1.Add(w1.PlaceMonkey("Jos", IDgenerator.GetMonkeyID()));

            //Task.WaitAll(tasks1.ToArray());


            w1.PlaceMonkey("Alice", IDgenerator.GetMonkeyID());
            w1.PlaceMonkey("Janice", IDgenerator.GetMonkeyID());
            w1.PlaceMonkey("Toby", IDgenerator.GetMonkeyID());
            w1.PlaceMonkey("Mindy", IDgenerator.GetMonkeyID());
            w1.PlaceMonkey("Jos", IDgenerator.GetMonkeyID());



            //List<Thread> threads1 = new List<Thread>();

            //threads1.Add(new Thread(() => w1.PlaceMonkey("Alice", IDgenerator.GetMonkeyID())));
            //threads1.Add(new Thread(() => w1.PlaceMonkey("Janice", IDgenerator.GetMonkeyID())));
            //threads1.Add(new Thread(() => w1.PlaceMonkey("Toby", IDgenerator.GetMonkeyID())));
            //threads1.Add(new Thread(() => w1.PlaceMonkey("Mindy", IDgenerator.GetMonkeyID())));
            //threads1.Add(new Thread(() => w1.PlaceMonkey("Jos", IDgenerator.GetMonkeyID())));

            //foreach (var thread in threads1)
            //{
            //    thread.Start();
            //}

            //foreach (var thread in threads1)
            //{
            //    thread.Join(); // Wacht op elke thread om te voltooien voordat verder te gaan
            //}



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            List<Task> tasks2 = new List<Task>();
            Map m2 = new Map(0, 200, 0, 400);

            WoodBuilder woodBuilder2 = new WoodBuilder();

            Wood w2 = await woodBuilder2.GetWood(500, m1, path, mdb);

            //tasks2.Add(w2.PlaceMonkey("Tom", IDgenerator.GetMonkeyID()));
            //tasks2.Add(w2.PlaceMonkey("Jerry", IDgenerator.GetMonkeyID()));
            //tasks2.Add(w2.PlaceMonkey("Tiffany", IDgenerator.GetMonkeyID()));
            //tasks2.Add(w2.PlaceMonkey("Mozes", IDgenerator.GetMonkeyID()));
            //tasks2.Add(w2.PlaceMonkey("Jebus", IDgenerator.GetMonkeyID()));

            //Task.WaitAll(tasks2.ToArray());



            w2.PlaceMonkey("Tom", IDgenerator.GetMonkeyID());
            w2.PlaceMonkey("Jerry", IDgenerator.GetMonkeyID());
            w2.PlaceMonkey("Tiffany", IDgenerator.GetMonkeyID());
            w2.PlaceMonkey("Mozes", IDgenerator.GetMonkeyID());
            w2.PlaceMonkey("Jebus", IDgenerator.GetMonkeyID());


            //List<Thread> threads2 = new List<Thread>();

            //threads2.Add(new Thread(() => w2.PlaceMonkey("Tom", IDgenerator.GetMonkeyID())));
            //threads2.Add(new Thread(() => w2.PlaceMonkey("Jerry", IDgenerator.GetMonkeyID())));
            //threads2.Add(new Thread(() => w2.PlaceMonkey("Tiffany", IDgenerator.GetMonkeyID())));
            //threads2.Add(new Thread(() => w2.PlaceMonkey("Mozes", IDgenerator.GetMonkeyID())));
            //threads2.Add(new Thread(() => w2.PlaceMonkey("Jebus", IDgenerator.GetMonkeyID())));

            //foreach (var thread in threads2)
            //{
            //    thread.Start();
            //}

            //foreach (var thread in threads2)
            //{
            //    thread.Join(); // Wacht op elke thread om te voltooien voordat verder te gaan
            //}



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            Map m3 = new Map(0, 400, 0, 400);
            WoodBuilder woodBuilder3 = new WoodBuilder();

            Wood w3 = await woodBuilder3.GetWood(500, m1, path, mdb);

            //List<Task> tasks3 = new List<Task>();

            //tasks3.Add(w3.PlaceMonkey("Kelly", IDgenerator.GetMonkeyID()));
            //tasks3.Add(w3.PlaceMonkey("Kenji", IDgenerator.GetMonkeyID()));
            //tasks3.Add(w3.PlaceMonkey("Kobe", IDgenerator.GetMonkeyID()));
            //tasks3.Add(w3.PlaceMonkey("Kendra", IDgenerator.GetMonkeyID()));

            //Task.WaitAll(tasks2.ToArray());


            w3.PlaceMonkey("Kelly", IDgenerator.GetMonkeyID());
            w3.PlaceMonkey("Kenji", IDgenerator.GetMonkeyID());
            w3.PlaceMonkey("Kobe", IDgenerator.GetMonkeyID());
            w3.PlaceMonkey("Kendra", IDgenerator.GetMonkeyID());



            //List<Thread> threads3 = new List<Thread>();

            //threads3.Add(new Thread(() => w3.PlaceMonkey("Kelly", IDgenerator.GetMonkeyID())));
            //threads3.Add(new Thread(() => w3.PlaceMonkey("Kenji", IDgenerator.GetMonkeyID())));
            //threads3.Add(new Thread(() => w3.PlaceMonkey("Kobe", IDgenerator.GetMonkeyID())));
            //threads3.Add(new Thread(() => w3.PlaceMonkey("Kendra", IDgenerator.GetMonkeyID())));

            //foreach (var thread in threads3)
            //{
            //    thread.Start();
            //}

            //foreach (var thread in threads3)
            //{
            //    thread.Join(); // Wacht op elke thread om te voltooien voordat verder te gaan
            //}


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //List<Task> taskswrite = new List<Task>();
            //taskswrite.Add(Task.Run(() => w1.WriteWoodToDB()));
            //taskswrite.Add(Task.Run(() => w2.WriteWoodToDB()));
            //taskswrite.Add(Task.Run(() => w3.WriteWoodToDB()));
            //Task.WaitAll(taskswrite.ToArray());


            //w1.WriteWoodToDB();
            //w2.WriteWoodToDB();
            //w3.WriteWoodToDB();


            //List<Thread> writeThreads = new List<Thread>();

            //writeThreads.Add(new Thread(() => w1.WriteWoodToDB()));
            //writeThreads.Add(new Thread(() => w2.WriteWoodToDB()));
            //writeThreads.Add(new Thread(() => w3.WriteWoodToDB()));

            //foreach (var thread in writeThreads)
            //{
            //    thread.Start();
            //}

            //foreach (var thread in writeThreads)
            //{
            //    thread.Join(); // Wacht op elke thread om te voltooien voordat verder te gaan
            //}


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //List<Task> tasksEscape = new List<Task>();
            //tasksEscape.Add(w1.Escape());
            //tasksEscape.Add(w2.Escape());
            //tasksEscape.Add(w3.Escape());

            //Task.WaitAll(tasksEscape.ToArray());


            //w1.Escape();
            //w2.Escape();
            //w3.Escape();


            //List<Thread> escapeThreads = new List<Thread>();

            //escapeThreads.Add(new Thread(() => w1.Escape()));
            //escapeThreads.Add(new Thread(() => w2.Escape()));
            //escapeThreads.Add(new Thread(() => w3.Escape()));

            //foreach (var thread in escapeThreads)
            //{
            //    thread.Start();
            //}

            //foreach (var thread in escapeThreads)
            //{
            //    thread.Join(); // Wacht op elke thread om te voltooien voordat verder te gaan
            //}


            List<Thread> threads = new List<Thread>();

            threads.Add(new Thread(() => w1.WriteWoodToDB()));
            threads.Add(new Thread(() => w2.WriteWoodToDB()));
            threads.Add(new Thread(() => w3.WriteWoodToDB()));

            threads.Add(new Thread(() => w1.Escape()));
            threads.Add(new Thread(() => w2.Escape()));
            threads.Add(new Thread(() => w3.Escape()));

            foreach (var thread in threads)
            {
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join(); // Wacht op elke thread om te voltooien voordat verder te gaan
            }




            stopwatch.Stop();
            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine("end");
        }
    }
}
