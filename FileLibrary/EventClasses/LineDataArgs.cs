using System;

namespace FileLibrary.EventClasses
{
    public class LineDataArgs : EventArgs
    {
        protected string[] Line;

        public LineDataArgs(string[] sender)
        {
            Line = sender;
        }
        public string[] LineArray => Line;
    }
}
