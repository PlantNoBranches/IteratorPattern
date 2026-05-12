using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var playlist = new PlaylistCollection();
            playlist.AddSong("Song A");
            playlist.AddSong("Song B");
            playlist.AddSong("Song C");

            foreach (var song in playlist)
            {
                Console.WriteLine(song);
            }
        }
    }
}
    