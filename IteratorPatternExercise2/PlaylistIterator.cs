using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternReverse
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
 
        }

        public override void Reset()
        {
            currentIndex = -1;
        }
    }
}