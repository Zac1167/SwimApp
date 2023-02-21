using System;
using System.Collections.Generic;

namespace SwimApp
{
    class Program
    {
        //Global variables
        static List<string> teamA = new List<string>();
        static List<string> teamB = new List<string>(); 
        static List<string> teamReserves = new List<string>();

        static float fastestTime = 99999f;
        static string topSwimmer = "";
        static void OneSwimmer()
        {
            Console.WriteLine("Enter the swimmer's name\n");
            string swimmerName = Console.ReadLine();
            Console.WriteLine($"\nSwimmer name: {swimmerName}\n");

            int sumTotalTime = 0;

            //Loop 4 times
            for (int i = 0; i < 4; i++)
            {
                int minutes, seconds, totalTime = 0;
                //Generate a random number between 1 and 4, and 0 and 59 (incl)
                Random randomNumber = new Random();
                minutes = randomNumber.Next(1, 4);
                seconds = randomNumber.Next(0, 59);
                totalTime = (minutes * 60) + seconds;
                Console.WriteLine($"Swimmer Time {i + 1}: {minutes} min, {seconds} sec\tTotal Time in Seconds: {totalTime}sec\n");
                //Next line is = to: sumTotalTime = sumTotalTime + totalTime
                sumTotalTime += totalTime;
            }

            float avgTime = (float)sumTotalTime / 4;
            string allocatedTeam = "Reserve";
            
            //Assign the swimmer to a team
            if(avgTime <= 160)
            {
                teamA.Add(swimmerName);
                allocatedTeam = "A";
            }
            else if(avgTime <= 210)
            {
                teamB.Add(swimmerName);
                allocatedTeam = "B";
            }
            else
            {
                teamReserves.Add(swimmerName);
            }
            Console.WriteLine($"Avg time = {avgTime}\n");
            if (avgTime <= fastestTime)
            {
                fastestTime = avgTime;
                topSwimmer = 
            }
            Console.WriteLine($"{swimmerName} = Team {allocatedTeam}");
        }
            
        static void Main(string[] args)
        {
            string flag = "Stop";
            while (!flag.Equals(""))
            {
                OneSwimmer();
                Console.WriteLine("\nPress 'Enter' to add another swimmer.\nOr type 'Stop' to end.");
                flag = Console.ReadLine();
            }
            Console.WriteLine($"The fastest swimmer was {topSwimmer} with an average time of {fastestTime}!");
        }
    }
}
