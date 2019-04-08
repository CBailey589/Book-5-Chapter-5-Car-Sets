using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an empty HashSet named Showroom that will contain strings.
            HashSet<string> Showroom = new HashSet<string>();

            // Add four of your favorite car model names to the set.
            Showroom.Add("Civic");
            Showroom.Add("WRX");
            Showroom.Add("CRV");
            Showroom.Add("Sebring");

            // Print to the console how many cars are in your show room.
            Console.WriteLine($"The Showroom has {Showroom.Count} cars in it");

            // Pick one of the items in your show room and add it to the set again.
            Showroom.Add("Civic");

            // Print your showroom again, and notice how there's still only one representation of that model in there.
            Console.WriteLine($"The Showroom still has only {Showroom.Count} cars in it...");

            // Create another set named UsedLot and add two more car model strings to it.
             HashSet<string> UsedLot = new HashSet<string>();
             UsedLot.Add("Tundra");
             UsedLot.Add("Blazer");

            //  Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);
            Console.WriteLine($"The Showroom has {Showroom.Count} cars (including the Used Car Lot)");

            // You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("Sebring");
            Console.WriteLine($"Somebody bougt the Sebring, the Showroom now has {Showroom.Count} cars in it");

            // Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Civic");
            Junkyard.Add("WRX");
            Junkyard.Add("CRV");
            Junkyard.Add("Sebring");
            Junkyard.Add("Tundra");
            Junkyard.Add("Blazer");
            Junkyard.Add("M1A1");
            Junkyard.Add("M88");
            Junkyard.Add("HMMWV");
            Junkyard.Add("7 Ton");

            // Create a new HashSet of your show room with HashSet<string> clone = new HashSet<string>(Showroom);
            HashSet<string> clone = new HashSet<string>(Showroom);

            // Use the IntersectWith() method on the clone to see which cars exist in both the show room and the junkyard.
            clone.IntersectWith(Junkyard);

           foreach (string car in clone)
           {
               Console.WriteLine($"clone: {car}");
           }

            // Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith(Junkyard);

            foreach (string car in Showroom)
            {
                Console.WriteLine($"showroom: {car}");
            }

            // Use the Remove() method to remove any cars that you acquired from the junkyard that you don't want in your showroom.
            Showroom.Remove("Civic");
            Showroom.Remove("WRX");
            Showroom.Remove("CRV");
            Showroom.Remove("Sebring");
            Showroom.Remove("Tundra");
            Showroom.Remove("Blazer");

            foreach (string car in Showroom)
            {
                Console.WriteLine($"improved showroom: {car}");
            }

        }
    }
}
