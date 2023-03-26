using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title.Length < 100);
        Contract.Requires(title != null);
        this.title = title;
        var random = new Random();
        this.id = random.Next(10000, 99999);
        this.playCount = 0;
    }
        public void IncreasePlayCount(int count)
        { 
        Contract.Requires(count <= 10000000);
        try
        {
            this.playCount = checked(this.playCount + count);
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Overflow Exception : " + e.Message);
        }
    }


public void PrintVideoDetails()
{
    Console.WriteLine("===Video Details===");
    Console.WriteLine("Video ID\t: " + this.id);
    Console.WriteLine("Title\t\t: " + this.title);
    Console.WriteLine("Play Count\t: " + this.playCount);
}
} 