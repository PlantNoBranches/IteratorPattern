using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternMerged
{
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
}