using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace GamehighSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            //    //Serialize
            //    CScoreEntry[] ScoreEntry =
            //    {
            //        new CScoreEntry{PlayerName="Lora", Points = 15},
            //        new CScoreEntry{PlayerName = "Kaira", Points = 25}
            //    };
            JsonSerializerOptions options = new JsonSerializerOptions();
              options.WriteIndented = true;
                string filename = "highscores.json";
                //string jsonserialize = JsonSerializer.Serialize(ScoreEntry, options);
                //File.WriteAllText(filename, jsonserialize);
                //Console.WriteLine("Scores saved!");

                //Deserialize
                if (File.Exists(filename))
                {
                    int points = 0;
                    string readtext = File.ReadAllText(filename);
                    List<CScoreEntry> loadedScores = JsonSerializer.Deserialize<List<CScoreEntry>>(readtext);
                    Console.Write("Enter a new player's name: ");
                    string player = Console.ReadLine();
                    Console.Write("Enter a new player's points: ");
                    while(!(int.TryParse(Console.ReadLine(), out points) && points >= 0))
                    {
                        Console.WriteLine("Invalid input!");
                        Console.Write("Enter a new player's points: ");
                    }
                    CScoreEntry scoreentry = new CScoreEntry();
                    scoreentry.PlayerName = player;
                    scoreentry.Points = points;
                    loadedScores.Add(scoreentry);
                    JsonSerializerOptions options2 = new JsonSerializerOptions();
                    options2.WriteIndented = true;
                    string jsonserialize2 = JsonSerializer.Serialize(loadedScores, options);
                    File.WriteAllText(filename, jsonserialize2);
                    Console.WriteLine("Scores saved!");

                    foreach (var newinfo in loadedScores)
                    {
                        Console.WriteLine(newinfo.PlayerName + ":" + newinfo.Points);
                    }
                }
                else
                {
                    File.Create(filename);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }
            Console.WriteLine("Press ay key to exit....");
            Console.ReadKey();
        }
    }
}
