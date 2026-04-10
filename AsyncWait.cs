using System;
using System.Threading.Tasks;
public class PlyerPf
{
    public string Username { get; set; }
    public int Level { get; set; }

}


class Program
{
    static async Task Main()
    {
        Console.WriteLine("----------Game menue___");
Console.WriteLine("Fetching player profile...\n");
Task<PlyerPf> playerProfileTask = FetchPlayerProfileAsync("Gamer123");
        while (playerProfileTask.IsCompleted == false)
        {
            Console.WriteLine("Loading...");
            await Task.Delay(500);
        }

        PlyerPf profile = await playerProfileTask;
        Console.WriteLine($"Welcome back, {profile.Username}! You are currently at level {profile.Level}.");
    }

    static async Task<PlyerPf> FetchPlayerProfileAsync(string username)
    {
        await Task.Delay(1000);
        return new PlyerPf { Username = username, Level = 5 };
    }
}