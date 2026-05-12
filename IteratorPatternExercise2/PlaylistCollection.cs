using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternReverse
{
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
}