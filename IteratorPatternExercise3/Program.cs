using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternMerged
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaylistCollection firstPlaylist = new PlaylistCollection();
            firstPlaylist.AddSong("Song A");
            firstPlaylist.AddSong("Song B");
            firstPlaylist.AddSong("Song C");

            PlaylistCollection secondPlaylist = new PlaylistCollection();
            secondPlaylist.AddSong("Song X");
            secondPlaylist.AddSong("Song Y");

            MergedPlaylistIterator iterator = new MergedPlaylistIterator(firstPlaylist, secondPlaylist);

            Console.WriteLine("Merged Playlist:");

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current());
            }
        }
    }
}