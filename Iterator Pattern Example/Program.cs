using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
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

    class PlaylistIterator : Iterator
    {
        private PlaylistCollection playlist;
        private int currentIndex = -1;

        public PlaylistIterator(PlaylistCollection playlistInput)
        {
            playlist = playlistInput;
        }

        public override object Current()
        {
            return playlist.GetSongs()[currentIndex];
        }

        public override bool MoveNext()
        {
            int nextIndex = currentIndex + 1;
            bool hasNextSong = nextIndex >= 0 && nextIndex < playlist.GetSongs().Count;

            if (hasNextSong)
            {
                currentIndex = nextIndex;
                return true;
            }
            else
            {
                return false;
            }
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
            return new PlaylistIterator(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var playlist = new PlaylistCollection();
            playlist.AddSong("Song A");
            playlist.AddSong("Song B");
            playlist.AddSong("Song C");

            Console.WriteLine("Playlist:");

            foreach (var song in playlist)
            {
                Console.WriteLine(song);
            }
        }
    }
}