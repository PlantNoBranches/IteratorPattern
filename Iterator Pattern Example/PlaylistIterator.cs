using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternExample
{
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
}