using System;

namespace MediaLibrary.Models
{
    public class Album : Media
    {
        public string artist { get; set; }
        public string recordLabel { get; set; }

        public override void Display()
        {
            Console.WriteLine(
            $"Id: {mediaId}\nTitle: {title}\nArtist: {artist}\nLabel: {recordLabel}\nGenres: {string.Join(", ", genres)}\n");
        }
    }
}