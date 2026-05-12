using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternMerged
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }

    class MergedPlaylistIterator : Iterator
    {
        private PlaylistCollection firstPlaylist;
        private PlaylistCollection secondPlaylist;
        private int currentIndex;

        public MergedPlaylistIterator(PlaylistCollection firstInput, PlaylistCollection secondInput)
        {
            firstPlaylist = firstInput;
            secondPlaylist = secondInput;
            currentIndex = -1;
        }

        public override object Current()
        {
            
        }

        public override bool MoveNext()
        {
            
        }

        public override void Reset()
        {
            currentIndex = -1;
        }
    }

    class PlaylistCollection : IteratorAggregate
    {
        private List<string> songs = new List<string>();

        public void AddSong(string songName)
        {
            songs.Add(songName);
        }

        public List<string> GetSongs()
        {
            return songs;
        }

        public override IEnumerator GetEnumerator()
        {
            return new MergedPlaylistIterator(this, new PlaylistCollection());
        }
    }

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