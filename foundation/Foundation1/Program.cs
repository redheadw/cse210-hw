using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //create video list/no Youtube
        Video video1 = new Video("C# 210", "Duane Richards", 820);
        video1.AddComment(new Comment("Gwyn", "This is really hard"));
        video1.AddComment(new Comment("Jane Doe", "Thank you for the tutorial"));
        video1.AddComment(new Comment("Sammi Sam", "My brain hurts"));

        Video video2 = new Video("Python for beginners", "Scott Burton", 983);
        video2.AddComment(new Comment("Billy Bob", "This is harder than roping an anger steer"));
        video2.AddComment(new Comment("Suzy Q", "Creating these comments takes a long time"));
        video2.AddComment(new Comment("Luke Duke", "Are we almost done yet"));

        Video video3 = new Video("How to fix a leaky facet", "John Doe", 630);
        video3.AddComment(new Comment("Henry VII", "Thank you the noise was making me crazy"));
        video3.AddComment(new Comment("Al Capon", "You saved my bunkmates life"));
        video3.AddComment(new Comment("Genghis Khan", "Whats a facet"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        } 
    }    
}