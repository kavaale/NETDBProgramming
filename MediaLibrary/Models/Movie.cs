using System;

namespace MediaLibrary.Models
{
    public class Movie : Media
    {
        public string director { get; set; }
        public TimeSpan runningTime { get; set; }

        public override void Display()
        {
            Console.WriteLine(
                $"Id: {mediaId}\nTitle: {title}\nDirector: {director}\nRun time: {runningTime}\nGenres: {string.Join(", ", genres)}\n");
        }
    }
}