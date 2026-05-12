using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternBlanks
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void ______();  // 1. Wie heißt diese Methode?
    }

    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator ______();  // 2. Wie heißt diese Methode?
    }

    class PlaylistIterator : ______  // 3. Von welcher Klasse erbt PlaylistIterator?
    {
        private PlaylistCollection _playlist;
        private int _currentIndex = ______;  // 4. Mit welchem Wert startet der Index?

        public PlaylistIterator(PlaylistCollection playlist)
        {
            _playlist = ______;  // 5. Was wird hier gespeichert?
        }

        public override object Current()
        {
            return _playlist.GetSongs()[______];  // 6. Welchen Index nutzen wir hier?
        }

        public override bool MoveNext()
        {
            int nextIndex = _currentIndex + ______;  // 7. Um wieviel erhöhen wir den Index?
            bool hasNextSong = nextIndex >= 0 && nextIndex < _playlist.GetSongs().______;  // 8. Welche Property gibt die Anzahl zurück?

            if (hasNextSong)
            {
                _currentIndex = nextIndex;
                return ______;  // 9. Was geben wir zurück wenn es einen nächsten Song gibt?
            }
            else
            {
                return ______;  // 10. Was geben wir zurück wenn nicht?
            }
        }

        public override void Reset()
        {
            _currentIndex = ______;  // 11. Auf welchen Wert setzen wir zurück?
        }
    }

    class PlaylistCollection : ______  // 12. Von welcher Klasse erbt PlaylistCollection?
    {
        private List<string> _songs = new List<string>();

        public void AddSong(string songName)
        {
            _songs.Add(songName);
        }

        public List<string> GetSongs()
        {
            return _songs;
        }

        public override IEnumerator GetEnumerator()
        {
            return new ______(this);  // 13. Welchen Iterator erstellen wir hier?
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

            foreach (var song in ______)  // 14. Worüber iterieren wir?
            {
                Console.WriteLine(song);
            }
        }
    }
}